import 'package:eprodaja_admin/main.dart';
import 'package:eprodaja_admin/models/order_details.dart';
import 'package:eprodaja_admin/models/order_header.dart';
import 'package:eprodaja_admin/providers/order_details_provider.dart';
import 'package:eprodaja_admin/providers/orders_provider.dart';
import 'package:eprodaja_admin/providers/product_provider.dart';
import 'package:eprodaja_admin/widgets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:provider/provider.dart';

class OrderDetailsScreen extends StatefulWidget {
  OrderHeader? narudzba;

  OrderDetailsScreen({super.key, this.narudzba});

  @override
  State<OrderDetailsScreen> createState() => _OrderDetailsScreenState();
}

class _OrderDetailsScreenState extends State<OrderDetailsScreen> {
  final _formKey = GlobalKey<FormBuilderState>();
  Map<String, dynamic> _initialValue = {};
  late OrderProvider _ordersProvider;
  late OrderDetailsProvider stavkaNarudzbeProvider;
  late ProductProvider productProvider;
  List<Order> stavkeNarudzbe = [];

  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _initialValue = {
      'orderHeaderId': widget.narudzba?.orderHeaderId,
      'status': widget.narudzba?.status,
      'orderDate': widget.narudzba?.orderDate.toString(),
      'totalPrice': widget.narudzba?.totalPrice.toString()
    };
    _ordersProvider = context.read()<OrderProvider>();
    stavkaNarudzbeProvider = OrderDetailsProvider();
    productProvider = ProductProvider();
    _fetchStavkeNarudzbe();

    initForm();
  }

  Future<void> _fetchStavkeNarudzbe() async {
    if (widget.narudzba == null) {
      setState(() {
        isLoading = false;
      });
      return;
    }

    try {
      var narudzbaId = widget.narudzba?.orderHeaderId;
      if (narudzbaId != null) {
        var result = await stavkaNarudzbeProvider
            .getStavkeNarudzbeByNarudzbaId(narudzbaId);
        setState(() {
          stavkeNarudzbe = result;
          isLoading = false;
        });
      }
    } catch (e) {
      // Handle error
      print(e);
      setState(() {
        isLoading = false;
      });
    }
  }

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
  }

  Future initForm() async {
    setState(() {
      isLoading = false;
    });
  }

  @override
  Widget build(BuildContext context) {
    var orderDetailState =
        Provider.of<OrderDetailsState>(context, listen: false);

    return MasterScreenWidget(
      child: Center(
        child: Container(
          decoration: BoxDecoration(
            border: Border.all(color: Colors.grey),
            borderRadius: BorderRadius.circular(8),
          ),
          padding: EdgeInsets.all(16),
          child: isLoading
              ? Container()
              : SingleChildScrollView(
                  child: _buildForm(),
                ),
        ),
      ),
      title: "Order ${this.widget.narudzba?.orderHeaderId}" ?? "Order details",
    );
  }

  FormBuilder _buildForm() {
    return FormBuilder(
      key: _formKey,
      initialValue: _initialValue,
      child: Column(
        children: [
          FormBuilderTextField(
            decoration: InputDecoration(labelText: "Order number"),
            name: 'orderHeaderId',
            readOnly: true,
          ),
          SizedBox(height: 10),
          FormBuilderTextField(
            decoration: InputDecoration(labelText: "Status"),
            name: 'status',
            onChanged: (value) {
              final currentValue = _initialValue['status'];
              print(currentValue);
            },
            validator: (value) {
              if (value != null && value.isNotEmpty) {
                final currentValue = _initialValue['status'];
                final newValue = value;

                final allowedTransitions = {
                  'Pending': ['Completed', 'Cancelled'],
                  'Cancelled': ['Pending'],
                };

                if (currentValue != newValue) {
                  if (allowedTransitions.containsKey(currentValue) &&
                      allowedTransitions[currentValue] != null &&
                      !allowedTransitions[currentValue]!.contains(newValue)) {
                    return "Invalid status transition (Allowed transitions: Pending -> Completed/Cancelled; Cancelled -> Pending)";
                  }
                }
              }
              return null;
            },
          ),
          SizedBox(height: 10),
          FormBuilderTextField(
            decoration: InputDecoration(labelText: "Total amount"),
            name: 'totalPrice',
            readOnly: true,
          ),
          SizedBox(height: 10),
          FormBuilderTextField(
            decoration: InputDecoration(labelText: "Order date"),
            name: 'orderDate',
            readOnly: true,
          ),
          SizedBox(height: 20),
          Text(
            'Order details :',
            style: TextStyle(
              fontSize: 18,
              fontWeight: FontWeight.normal,
            ),
          ),
          if (stavkeNarudzbe.isNotEmpty)
            ...stavkeNarudzbe.asMap().entries.map((entry) {
              final index = entry.key;
              final stavka = entry.value;

              return Column(
                children: [
                  FormBuilderTextField(
                    decoration: InputDecoration(labelText: 'Quantity'),
                    name: 'quantity',
                    readOnly: true,
                    initialValue: stavka.quantity.toString(),
                  ),
                  FutureBuilder<String>(
                    future: _getProductName(stavka.productId),
                    builder: (context, snapshot) {
                      if (snapshot.connectionState == ConnectionState.done) {
                        return FormBuilderTextField(
                          decoration:
                              InputDecoration(labelText: 'Product name'),
                          name: 'nazivProizvoda_$index',
                          readOnly: true,
                          initialValue: snapshot.data ?? 'N/A',
                        );
                      } else {
                        return CircularProgressIndicator();
                      }
                    },
                  ),
                  SizedBox(height: 20),
                ],
              );
            }).toList(),
          SizedBox(height: 20),
          Row(
            mainAxisAlignment: MainAxisAlignment.end,
            children: [
              ElevatedButton(
                onPressed: () async {
                  if (_formKey.currentState?.validate() ?? false) {
                    _formKey.currentState?.save();
                    print(_formKey.currentState?.value);

                    var request =
                        Map<String, dynamic>.from(_formKey.currentState!.value);

                    try {
                      if (widget.narudzba == null) {
                        await _ordersProvider.insert(request);
                      } else {
                        var currentStatus = _initialValue['status'];
                        var newStatus = request['status'];

                        if (currentStatus == 'Completed') {
                          showDialog(
                            context: context,
                            builder: (BuildContext context) => AlertDialog(
                              title: Text("Error"),
                              content: Text(
                                  "Cannot transition from 'Completed' status."),
                              actions: [
                                TextButton(
                                  onPressed: () => Navigator.pop(context),
                                  child: Text("OK"),
                                ),
                              ],
                            ),
                          );
                        } else {
                          await _ordersProvider.update(
                            widget.narudzba!.orderHeaderId!,
                            request,
                          );
                          ScaffoldMessenger.of(context).showSnackBar(SnackBar(
                            content: Text('Order status successfully updated.'),
                            backgroundColor: Colors.green,
                          ));
                          Navigator.pop(context, 'reload');
                          //}
                        }
                      }
                    } on Exception catch (e) {
                      showDialog(
                        context: context,
                        builder: (BuildContext context) => AlertDialog(
                          title: Text("Error"),
                          content: Text(e.toString()),
                          actions: [
                            TextButton(
                              onPressed: () => Navigator.pop(context),
                              child: Text("OK"),
                            ),
                          ],
                        ),
                      );
                    }
                  }
                },
                child: Text("Save"),
              ),
            ],
          ),
        ],
      ),
    );
  }

  Future<String> _getProductName(int? productId) async {
    if (productId == null) {
      return 'N/A';
    }

    try {
      var product = await productProvider.getById(productId);
      return product.productName ?? 'N/A';
    } catch (e) {
      return 'N/A';
    }
  }
}
