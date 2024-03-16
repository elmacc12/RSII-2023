import 'dart:io';

import 'package:eprodaja_admin/models/transakcije.dart';
import 'package:eprodaja_admin/providers/transakcije_provider.dart';
import 'package:eprodaja_admin/widgets/blue_button.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:pdf/pdf.dart';
import 'package:printing/printing.dart';
import 'package:provider/provider.dart';
import 'package:pdf/widgets.dart' as pw;

class TransactionsPage extends StatefulWidget {
  const TransactionsPage({Key? key}) : super(key: key);

  @override
  _TransactionsPagePageState createState() => _TransactionsPagePageState();
}

class _TransactionsPagePageState extends State<TransactionsPage> {
  late TransactionsProvider _transactionProvider;
  List<Transactions> transakcije = [];

  @override
  void initState() {
    super.initState();
    _transactionProvider =
        Provider.of<TransactionsProvider>(context, listen: false);
    _fetchBlogs();
  }

  Future<void> _fetchBlogs() async {
    try {
      var data = await _transactionProvider.get();

      setState(() {
        transakcije = data.result;
      });
    } catch (e) {
      print(e);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Lista transakcija', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          SizedBox(height: 20),
          BlueButton(
            text: 'Kreiraj izvjestaj',
            width: 200,
            height: 40,
            onPressed: () async {
              final pdf = await _generatePDFReport();
              await _printPDFReport(pdf);
            },
          ),
          Expanded(
            child: _buildBlogList(),
          ),
        ],
      ),
    );
  }

  Widget _buildBlogList() {
    if (transakcije.isEmpty) {
      return Center(
        child: Text('Nema dostupnih transakcija.'),
      );
    }

    return ListView.builder(
      itemCount: transakcije.length,
      itemBuilder: (context, index) {
        return _buildBlogCard(transakcije[index]);
      },
    );
  }

  Widget _buildBlogCard(Transactions t) {
    return Card(
      margin: EdgeInsets.all(8.0),
      elevation: 4.0,
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          ListTile(
            title: Text("Uplata za narudzbu ${t.orderHeaderId.toString()}"),
            subtitle: Text("Iznos uplate ${t.amount.toString()}"),
          ),
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: BlueButton(
              text: 'Print',
              width: 80,
              height: 30,
              onPressed: () async {
                final pdf = await _generateSingleTransactionPDF(t);
                await _printPDFReport(pdf);
              },
            ),
          ),
        ],
      ),
    );
  }

  Future<pw.Document> _generateSingleTransactionPDF(
      Transactions transaction) async {
    final pdf = pw.Document();

    pdf.addPage(
      pw.Page(
        build: (pw.Context context) {
          return pw.Center(
            child: pw.Container(
              decoration: pw.BoxDecoration(
                border: pw.Border.all(color: PdfColors.black, width: 2),
              ),
              padding: pw.EdgeInsets.all(20),
              child: pw.Column(
                children: [
                  pw.Text('Detalji transakcije',
                      style: pw.TextStyle(fontSize: 20)),
                  pw.SizedBox(height: 20),
                  _generateSingleTransactionPDFContent(transaction),
                ],
              ),
            ),
          );
        },
      ),
    );

    return pdf;
  }

  pw.Widget _generateSingleTransactionPDFContent(Transactions transaction) {
    return pw.Column(
      children: [
        pw.Row(
          children: [
            pw.Text('Narudzba: ${transaction.orderHeaderId}'),
          ],
        ),
        pw.Row(
          children: [
            pw.Text('Iznos transakcije: ${transaction.amount}'),
          ],
        ),
        pw.Row(
          children: [
            pw.Text('Status transakcije: ${transaction.transactionStatus}'),
          ],
        ),
        pw.Row(
          children: [
            pw.Text('Id transakcije: ${transaction.transId}'),
          ],
        ),
      ],
    );
  }

  Future<pw.Document> _generatePDFReport() async {
    final pdf = pw.Document();

    pdf.addPage(
      pw.Page(
        build: (pw.Context context) {
          return pw.Center(
            child: pw.Container(
              decoration: pw.BoxDecoration(
                border: pw.Border.all(color: PdfColors.black, width: 2),
              ),
              padding: pw.EdgeInsets.all(20),
              child: pw.Column(
                children: [
                  pw.Text('Pregled svih uplata',
                      style: pw.TextStyle(fontSize: 20)),
                  pw.SizedBox(height: 20),
                  _generatePDFContent(),
                ],
              ),
            ),
          );
        },
      ),
    );

    return pdf;
  }

  Future<void> _printPDFReport(pw.Document pdf) async {
    await Printing.layoutPdf(
      onLayout: (format) async => pdf.save(),
    );
  }

  pw.Widget _generatePDFContent() {
    if (transakcije != [] && transakcije.length > 0) {
      return pw.Column(
        children: transakcije!.map((t) {
          return pw.Container(
            padding: pw.EdgeInsets.symmetric(vertical: 8.0),
            child: pw.Column(
              children: [
                pw.Row(
                  children: [
                    pw.Text('Order ${t.orderHeaderId.toString()}'),
                  ],
                ),
                pw.Row(
                  children: [
                    pw.Text('Amount ${t.amount.toString()}'),
                  ],
                ),
              ],
            ),
          );
        }).toList(),
      );
    } else {
      return pw.Text('Nema podataka o transakcijama.');
    }
  }
}
