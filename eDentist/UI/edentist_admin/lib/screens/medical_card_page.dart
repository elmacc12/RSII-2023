import 'package:eprodaja_admin/models/dental_service.dart';
import 'package:eprodaja_admin/models/medical_card.dart';
import 'package:eprodaja_admin/models/user.dart';
import 'package:eprodaja_admin/providers/dentalService_provider.dart';
import 'package:eprodaja_admin/providers/medical_card_provider.dart';
import 'package:eprodaja_admin/utils/util.dart';
import 'package:eprodaja_admin/widgets/blue_button.dart';
import 'package:flutter/material.dart';
import 'package:collection/collection.dart';
import 'package:intl/intl.dart';
import 'package:pdf/pdf.dart';
import 'package:pdf/widgets.dart' as pw;
import 'package:printing/printing.dart';

class MedicalCardPage extends StatefulWidget {
  final User user;

  MedicalCardPage({required this.user});

  @override
  _MedicalCardPageState createState() => _MedicalCardPageState();
}

class _MedicalCardPageState extends State<MedicalCardPage> {
  final MedicalCardProvider _medicalCardProvider = MedicalCardProvider();
  final DentalServiceProvider _dentalServiceProvider = DentalServiceProvider();
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  bool isEditing = false;
  int editingIndex = -1;
  List<MedicalCard> medicalCards = [];
  List<DentalService> dentalServices = [];
  bool isLoading = true;
  int? _selectedService;

  @override
  void initState() {
    super.initState();
    fetchMedicalRecords();
    fetchDentalServices();
    setState(() {
      _selectedService = null;
    });
  }

  Future<void> fetchMedicalRecords() async {
    try {
      var result = await _medicalCardProvider.get();
      print(result.result);
      setState(() {
        medicalCards = result.result;
        isLoading = false;
      });
    } catch (e) {
      print(e);
      setState(() {
        isLoading = false;
      });
    }
  }

  Future<void> fetchDentalServices() async {
    try {
      var result = await _dentalServiceProvider.get();
      print(result.result);
      setState(() {
        dentalServices = result.result;
        isLoading = false;
      });
    } catch (e) {
      print(e);
      setState(() {
        isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(
            'Pregled kartona za pacijenta ' +
                widget.user.name.toString() +
                ' ' +
                widget.user.surname.toString(),
            style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            Row(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Container(
                  width: MediaQuery.of(context).size.width * 0.3,
                  child: Column(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: [
                      _buildUserImage(),
                      Text('Ime: ${widget.user.name}'),
                      Text('Prezime: ${widget.user.surname}'),
                    ],
                  ),
                ),
                Expanded(
                  child: Column(
                    children: [
                      DataTable(
                        columns: [
                          DataColumn(label: Text('Naziv dijagnoze')),
                          DataColumn(label: Text('Datum')),
                          DataColumn(label: Text('Mišljenje doktora')),
                        ],
                        rows: medicalCards
                            .where((mc) => mc.userId == widget.user.userId)
                            .map((medicalCard) {
                          DentalService? matchingService =
                              dentalServices.firstWhereOrNull((service) =>
                                  service.dentalServiceId ==
                                  medicalCard.dentalServiceId);
                          return DataRow(
                            cells: [
                              DataCell(
                                  Text(matchingService?.serviceName ?? "")),
                              DataCell(Text(
                                  medicalCard.datumDijagnoze.toString() ?? "")),
                              DataCell(Text(medicalCard.doctorsOppinion ?? "")),
                            ],
                          );
                        }).toList(),
                      ),
                      SizedBox(height: 16),
                      BlueButton(
                        text: 'Dodaj dijagnozu',
                        width: 200,
                        height: 40,
                        onPressed: () {
                          _showAddDiagnoseDialog();
                        },
                      ),
                      SizedBox(height: 20),
                      BlueButton(
                        text: 'Kreiraj izvještaj',
                        width: 200,
                        height: 40,
                        onPressed: () async {
                          final pdf = await _generatePDFReport();
                          await _printPDFReport(pdf);
                        },
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ],
        ),
      ),
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
                  pw.Text('PDF Report Content',
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
    if (widget.user.name != null && widget.user.surname != null) {
      return pw.Column(
        children: medicalCards!.map((dijagnoza) {
          return pw.Container(
            padding: pw.EdgeInsets.symmetric(vertical: 8.0),
            child: pw.Column(
              children: [
                pw.Row(
                  children: [
                    pw.Text('Ime pacijenta: ${widget.user.name}'),
                  ],
                ),
                pw.Row(
                  children: [
                    pw.Text('Prezime pacijenta:  ${widget.user.surname}'),
                  ],
                ),
                pw.Row(
                  children: [
                    pw.Text('Datum: ${dijagnoza.datumDijagnoze}'),
                  ],
                ),
                pw.Row(
                  children: [
                    pw.Text('Misljenje doktora:  ${dijagnoza.doctorsOppinion}'),
                  ],
                ),
              ],
            ),
          );
        }).toList(),
      );
    } else {
      return pw.Text('Nema podataka o dijagnozama pacijenta.');
    }
  }

  Future<void> _showAddDiagnoseDialog(
      {bool editing = false, MedicalCard? r}) async {
    isEditing = editing;
    if (editing) {
      editingIndex = medicalCards.indexOf(r!);
    }

    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text(editing ? 'Uredi uslugu' : 'Dodaj uslugu'),
          content: _buildAddRecordForm(record: r),
        );
      },
    );
  }

  Widget _buildAddRecordForm({MedicalCard? record}) {
    TextEditingController doctorsOppinionController =
        TextEditingController(text: record?.doctorsOppinion ?? "");

    return Form(
      key: _formKey,
      child: Column(
        children: [
          DropdownButton<int>(
            value: _selectedService,
            onChanged: isEditing
                ? null
                : (newValue) {
                    setState(() {
                      _selectedService = newValue;
                    });
                  },
            items: dentalServices.map<DropdownMenuItem<int>>((DentalService s) {
                  return DropdownMenuItem<int>(
                    value: s.dentalServiceId,
                    child: Text(s.serviceName!),
                  );
                }).toList() ??
                [],
            isExpanded: true,
            disabledHint: Text(
              _selectedService != null
                  ? 'Selected Dental Service ID: $_selectedService'
                  : 'Select a Dental Service',
            ),
          ),
          TextFormField(
            controller: doctorsOppinionController,
            decoration: InputDecoration(labelText: 'Mišljenje doktora'),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Unesite mišljenje doktora';
              }
              return null;
            },
          ),
          ElevatedButton(
            onPressed: () async {
              if (_formKey.currentState?.validate() ?? false) {
                var request = {
                  'userId': widget.user.userId,
                  'dentalServiceId': _selectedService,
                  'doctorsOppinion': doctorsOppinionController.text,
                  'datumDijagnoze': DateTime.now(),
                };

                try {
                  if (isEditing) {
                    await _medicalCardProvider.update(
                        medicalCards[editingIndex].medicalCardId!, request);
                  } else {
                    await _medicalCardProvider.insert(request);
                  }

                  await fetchMedicalRecords();
                  Navigator.pop(context);
                  ScaffoldMessenger.of(context).showSnackBar(
                    SnackBar(
                      content: Text(
                          'Dijagnoza ${isEditing ? 'uređena' : 'dodana'} uspješno.'),
                      backgroundColor: Colors.green,
                    ),
                  );
                } catch (e) {
                  print(e);
                }
              }
            },
            child: Text(isEditing ? 'Uredi' : 'Dodaj'),
          ),
        ],
      ),
    );
  }

  Widget _buildUserImage() {
    if (widget.user.slika != null) {
      return Container(
        height: 200,
        width: 200,
        child: imageFromBase64String(widget.user.slika ?? ""),
      );
    } else {
      return Container(
        height: 50,
        width: 50,
        color: Colors.grey,
      );
    }
  }
}
