import 'package:eprodaja_admin/models/order_header.dart';
import 'package:eprodaja_admin/providers/orders_provider.dart';
import 'package:eprodaja_admin/screens/order_details.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class OrdersListScreen extends StatefulWidget {
  const OrdersListScreen({Key? key}) : super(key: key);

  @override
  State<OrdersListScreen> createState() => _OrdersListScreenState();
}

class _OrdersListScreenState extends State<OrdersListScreen> {
  final OrderProvider _ordersProvider = OrderProvider();
  List<OrderHeader> _narudzba = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _fetchNarudzbe();
  }

  Future<void> _fetchNarudzbe() async {
    try {
      var result = await _ordersProvider.get();
      print(result.result);
      setState(() {
        _narudzba = result.result;
        isLoading = false;
      });
    } catch (e) {
      // Handle error
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
        title: Text('Orders'),
      ),
      body: Column(
        children: [
          _buildDataListView(),
        ],
      ),
    );
  }

  Widget _buildDataListView() {
    if (isLoading) {
      return Expanded(
        child: Center(
          child: CircularProgressIndicator(),
        ),
      );
    }

    if (_narudzba.isEmpty) {
      return Expanded(
        child: Center(
          child: Text('Trenutno nema narudžbi'),
        ),
      );
    }

    return Expanded(
      child: ListView.builder(
        itemCount: _narudzba.length,
        itemBuilder: (context, index) {
          var narudzba = _narudzba[index];
          return Padding(
            padding: const EdgeInsets.symmetric(vertical: 8.0),
            child: MouseRegion(
              cursor: SystemMouseCursors.click,
              child: Card(
                elevation: 2,
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(8),
                ),
                child: ListTile(
                  onTap: () async {
                    var refresh =
                        await Navigator.of(context).push(MaterialPageRoute(
                      builder: (context) =>
                          OrderDetailsScreen(narudzba: narudzba),
                    ));
                    if (refresh == 'reload') {
                      _fetchNarudzbe();
                    }
                  },
                  title: Text(narudzba.orderHeaderId.toString() ?? ''),
                  subtitle: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(narudzba.totalPrice.toString() ?? ''),
                      SizedBox(height: 8),
                      Text(
                        'Created on: ${narudzba.orderDate != null ? DateFormat('yyyy-MM-dd').format(narudzba.orderDate!) : 'Unknown Date'}',
                        style: TextStyle(fontStyle: FontStyle.italic),
                      ),
                    ],
                  ),
                ),
              ),
            ),
          );
        },
      ),
    );
  }
}
