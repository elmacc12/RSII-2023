import 'package:edentist_mobile/providers/product_provider.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'package:flutter_paypal_checkout/flutter_paypal_checkout.dart';

class PaypalScreen extends StatefulWidget {
  final List<Map<String, dynamic>> items;
  final int korisnikId;
  final int? narudzbaId;
  // final double? iznos;

  PaypalScreen(
      {required this.items,
      required this.korisnikId,
      required this.narudzbaId,
      // required this.iznos,
      super.key});

  @override
  State<PaypalScreen> createState() => _PaypalScreenState();
}

class _PaypalScreenState extends State<PaypalScreen> {
  late List<Map<String, dynamic>> itemList = [];
  late ProductProvider _productProvider;

  @override
  void initState() {
    super.initState();
    _productProvider = Provider.of<ProductProvider>(context, listen: false);

    _navigateToPaypalCheckout();
  }

  void _navigateToPaypalCheckout() async {
    // double totalAmount = await calculateTotalAmount(widget.items);
    // await buildItemList(widget.items);

    Navigator.of(context).pushReplacement(MaterialPageRoute(
      builder: (BuildContext context) => PaypalCheckout(
        sandboxMode: true,
        clientId:
            "AcpO0QFqLq6goMjiJfOA3W65sl8K20Puv_gclX_pdNCYAPD-iiCgBdxZ9Q_dTbvTNkRcqhvCS86Z5PQ9",
        secretKey:
            "AcpO0QFqLq6goMjiJfOA3W65sl8K20Puv_gclX_pdNCYAPD-iiCgBdxZ9Q_dTbvTNkRcqhvCS86Z5PQ9",
        returnURL: "return.example.com",
        cancelURL: "cancel.example.com",
        transactions: [
          {
            "amount": {
              "total": 20, // totalAmount.toStringAsFixed(2),
              "currency": "USD",
              "details": {
                "subtotal": 20, // totalAmount.toStringAsFixed(2),
                "shipping": '0',
                "shipping_discount": 0,
              },
            },
            "description": "The payment transaction description.",
            //"payment_options": {
            //  "allowed_payment_method": "INSTANT_FUNDING_SOURCE"
            //},
            "item_list": {"items": itemList},
          }
        ],
        note: "Contact us for any questions on your order.",
        onSuccess: (Map params) async {
          print("onSuccess: $params");
          if (params['data']['state'] == 'approved') {
            /*Transakcija request = Transakcija(
              null,
              widget.narudzbaId,
              widget.iznos,
              params['data']['id'],
              params['data']['state'],
            );
            await _transakcijaProvider.insert(request);

            _cartProvider.cart.items.clear();
            total = 0.00;*/

            ScaffoldMessenger.of(context).showSnackBar(
              SnackBar(
                content: Text('Order has been processed.'),
                backgroundColor: Colors.green,
              ),
            );
            // Navigator.pop(context, 'reload');
          } else {
            print('Payment was not successful');
          }
        },
        onError: (error) {
          print("onError: $error");
          Navigator.pop(context);
        },
        onCancel: () {
          print('Payment canceled');
        },
      ),
    ));
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text(
          "PayPal Checkout",
          style: TextStyle(fontSize: 20),
        ),
      ),
      body: Center(),
    );
  }

  Future<void> buildItemList(List<Map<String, dynamic>> items) async {
    itemList.clear();
    print(items.length.toString());

    double totalAmount = await calculateTotalAmount(items);

    for (var i = 0; i < items.length; i++) {
      if (i < items.length) {
        int proizvodID = items[i]["productId"];
        final product = await _productProvider.getById(proizvodID);
        if (product != null) {
          String productName = product.productName!;
          int quantity = items[i]["quantityLeft"];
          int price = product.productPrice;
          totalAmount += price * quantity;
          itemList.add({
            "name": productName,
            "quantity": quantity,
            "price": price.toStringAsFixed(2),
            "currency": "USD",
          });
          print(itemList);
        }
      } else {}
    }

    print("Total Amount: $totalAmount");
  }

  Future<double> calculateTotalAmount(List<Map<String, dynamic>> items) async {
    double total = 0.0;

    for (var item in items) {
      int proizvodID = item["proizvodID"];
      int quantity = item["kolicina"];

      final product = await _productProvider.getById(proizvodID);

      if (product != null) {
        int price = product.productPrice;
        total += price * quantity;
      }
    }

    return total;
  }
}
