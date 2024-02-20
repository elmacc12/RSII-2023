// ignore_for_file: use_build_context_synchronously
import 'package:edentist_mobile/models/cart.dart';
import 'package:edentist_mobile/providers/cart_provider.dart';
import 'package:edentist_mobile/providers/oreder_providet.dart';
import 'package:edentist_mobile/providers/user_provider.dart';
import 'package:edentist_mobile/utils/util.dart';
import 'package:edentist_mobile/widgets/master_screen_widget.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class CartScreen extends StatefulWidget {
  const CartScreen({Key? key}) : super(key: key);

  @override
  State<CartScreen> createState() => _CartScreenState();
}

double total = 0;

class _CartScreenState extends State<CartScreen> {
  late CartProvider _cartProvider;
  late OrderProvider _orderProvider;
  late UserProvider _korisniciProvider;

  @override
  void initState() {
    super.initState();
  }

  @override
  void didChangeDependencies() {
    super.didChangeDependencies();
    _cartProvider = context.watch<CartProvider>();
    _orderProvider = context.watch<OrderProvider>();
    _korisniciProvider = context.watch<UserProvider>();
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      title: "Cart",
      child: Column(
        children: [
          Expanded(
            child: _cartProvider.cart.items.isNotEmpty
                ? _buildProductCardList()
                : const Center(child: Text("Your cart is empty.")),
          ),
          const SizedBox(
            height: 15,
          ),
          Padding(
            padding: const EdgeInsets.all(10.0),
            child: Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Text(
                  "Total : $total KM",
                  style: const TextStyle(fontSize: 18),
                ),
                _buildBuyButton(),
              ],
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildProductCardList() {
    return Container(
      child: ListView.builder(
        itemCount: _cartProvider.cart.items.length,
        itemBuilder: (context, index) {
          return _buildProductCard(_cartProvider.cart.items[index]);
        },
      ),
    );
  }

  Widget _buildProductCard(CartItem item) {
    return Row(
      children: [
        SizedBox(
          width: 100,
          height: 100,
          child: imageFromBase64String(item.product.slika!),
        ),
        const SizedBox(width: 10),
        Expanded(
          child: ListTile(
            title: Text(item.product.productName ?? ""),
            subtitle: Text(item.product.productPrice.toString()),
            trailing: Row(
              mainAxisSize: MainAxisSize.min,
              children: [
                IconButton(
                  icon: const Icon(Icons.remove),
                  onPressed: () {
                    _cartProvider.decreaseQuantity(item.product);
                  },
                ),
                Text(item.count.toString()),
                IconButton(
                  icon: const Icon(Icons.add),
                  onPressed: () {
                    _cartProvider.addToCart(item.product);
                  },
                ),
              ],
            ),
          ),
        ),
      ],
    );
  }

  Future<int> getPatientId() async {
    final pacijenti = await _korisniciProvider.get();

    final pacijent = pacijenti.result
        .firstWhere((korisnik) => korisnik.username == Authorization.username);

    return pacijent.userId;
  }

  Future<String> getPatientLastName() async {
    final pacijenti = await _korisniciProvider.get();

    final pacijent = pacijenti.result
        .firstWhere((korisnik) => korisnik.username == Authorization.username);

    return pacijent.surname!;
  }

  Future<String> getPatientAddress() async {
    final pacijenti = await _korisniciProvider.get();

    final pacijent = pacijenti.result
        .firstWhere((korisnik) => korisnik.username == Authorization.username);

    return pacijent.adress!;
  }

  Future<String> getPatientPhone() async {
    final pacijenti = await _korisniciProvider.get();

    final pacijent = pacijenti.result
        .firstWhere((korisnik) => korisnik.username == Authorization.username);

    return pacijent.email!;
  }

  Widget _buildBuyButton() {
    return TextButton(
      style: TextButton.styleFrom(
        backgroundColor: const Color.fromARGB(255, 168, 204, 235),
        foregroundColor: Colors.black,
      ),
      onPressed: _cartProvider.cart.items.isEmpty
          ? null
          : () async {
              List<Map<String, dynamic>> items = [];

              for (var item in _cartProvider.cart.items) {
                items.add(
                  {
                    "proizvodID": item.product.productId,
                    "kolicina": item.count,
                  },
                );
              }
              int patientId = await getPatientId();

              Map<String, dynamic> order = {
                "items": items,
                "korisnikId": await getPatientId(),
              };

              var response = await _orderProvider.insert(order);

              setState(() {});

              // Navigator.of(context).push(
              //   MaterialPageRoute(
              //     builder: (context) => PaymentScreen(
              //         items: items,
              //         korisnikId: patientId,
              //         narudzbaId: response?.orderHeaderId,
              //         iznos: response?.totalPrice),
              //   ),
              // );
            },
      child: const Text("Buy"),
    );
  }
}
