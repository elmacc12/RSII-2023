import 'package:edentist_mobile/models/favorite.dart';
import 'package:edentist_mobile/models/product.dart';
import 'package:edentist_mobile/providers/favorites_provider.dart';
import 'package:edentist_mobile/providers/product_provider.dart';
import 'package:edentist_mobile/providers/user_provider.dart';
import 'package:edentist_mobile/utils/util.dart';
import 'package:edentist_mobile/widgets/master_screen_widget.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class FavoritesScreen extends StatefulWidget {
  const FavoritesScreen({Key? key}) : super(key: key);

  @override
  State<FavoritesScreen> createState() => _FavoritesScreenState();
}

class _FavoritesScreenState extends State<FavoritesScreen> {
  late FavoritesProvider _favoritesProvider;
  late UserProvider _korisniciProvider;
  late ProductProvider _productProvider;
  List<Favorite> favoriteProducts = [];

  @override
  void initState() {
    super.initState();
    _favoritesProvider = Provider.of<FavoritesProvider>(context, listen: false);
    _korisniciProvider = Provider.of<UserProvider>(context, listen: false);
    _productProvider = Provider.of<ProductProvider>(context, listen: false);

    _fetchFavorites();
  }

  Future<void> _fetchFavorites() async {
    try {
      final patientId = await getPatientId();
      var data = await _favoritesProvider.get(filter: {
        'korisnikId': patientId.toString(),
      });
      setState(() {
        favoriteProducts = data.result;
      });
    } catch (e) {}
  }

  Future<int> getPatientId() async {
    final pacijenti = await _korisniciProvider.get(filter: {
      'tipKorisnika': 'pacijent',
    });

    final pacijent = pacijenti.result.firstWhere(
      (korisnik) => korisnik.username == Authorization.username,
    );

    return pacijent.userId!;
  }

  @override
  Widget build(BuildContext context) {
    return MasterScreenWidget(
      titleWidget: Text("Favorites"),
      child: SingleChildScrollView(
        scrollDirection: Axis.horizontal,
        child: DataTable(
          columns: const [
            DataColumn(label: Text('Image')),
            DataColumn(label: Text('')),
          ],
          rows: favoriteProducts
              .map((favorite) => DataRow(
                    cells: [
                      DataCell(
                        favoriteProducts.isNotEmpty
                            ? Container(
                                width: 100,
                                height: 100,
                                child: FutureBuilder<Product?>(
                                  future: _productProvider
                                      .getById(favorite.productId!),
                                  builder: (context, snapshot) {
                                    if (snapshot.connectionState ==
                                        ConnectionState.waiting) {
                                      return CircularProgressIndicator();
                                    } else if (snapshot.hasError) {
                                      return Text('Error');
                                    } else if (!snapshot.hasData ||
                                        snapshot.data == null) {
                                      return Text('Product not found');
                                    } else {
                                      final product = snapshot.data!;
                                      return imageFromBase64String(
                                          product.slika!);
                                    }
                                  },
                                ),
                              )
                            : Text(""),
                      ),
                      DataCell(
                        ElevatedButton(
                          onPressed: () => _deleteFavorite(favorite.productId),
                          child: Text('Delete'),
                        ),
                      ),
                    ],
                  ))
              .toList(),
        ),
      ),
    );
  }

  _deleteFavorite(int? omiljeniProizvodId) async {
    try {
      await _favoritesProvider.delete(omiljeniProizvodId);
      _fetchFavorites();
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Product successfully removed from favorites.")),
      );
    } catch (e) {}
  }
}
