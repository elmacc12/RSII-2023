import 'package:eprodaja_admin/models/product.dart';
import 'package:eprodaja_admin/models/search_result.dart';
import 'package:eprodaja_admin/providers/product_provider.dart';
import 'package:eprodaja_admin/screens/product_detail_screen.dart';
import 'package:eprodaja_admin/utils/util.dart';
import 'package:eprodaja_admin/widgets/master_screen.dart';
import 'package:flutter/material.dart';
import 'package:flutter_form_builder/flutter_form_builder.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

class ProductsPage extends StatefulWidget {
  const ProductsPage({Key? key}) : super(key: key);

  @override
  State<ProductsPage> createState() => _ProductListScreenState();
}

class _ProductListScreenState extends State<ProductsPage> {
  late ProductProvider _productProvider;
  SearchResult<Product>? result;
  bool isLoading = true;
  TextEditingController _ftsController = new TextEditingController();
  TextEditingController _sifraController = new TextEditingController();
  final _formKey = GlobalKey<FormBuilderState>();

  String _selectedSortDirection = 'ascending';

  @override
  void initState() {
    super.initState();
    _productProvider = Provider.of<ProductProvider>(context, listen: false);
    _fetchProducts();
  }

  Future<void> _fetchProducts() async {
    try {
      var data = await _productProvider.get(filter: {
        'fts': _ftsController.text,
        'sifra': _sifraController.text,
      });

      setState(() {
        result = data;
        if (_selectedSortDirection == 'ascending') {
          result?.result
              .sort((a, b) => a.productPrice!.compareTo(b.productPrice!));
        } else {
          result?.result
              .sort((a, b) => b.productPrice!.compareTo(a.productPrice!));
        }
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
    return MasterScreenWidget(
      title_widget: Text("Proizvodi"),
      child: Column(
        children: [
          _buildSearch(),
          _buildDataListView(),
        ],
      ),
    );
  }

  Widget _buildSearch() {
    return FormBuilder(
      key: _formKey,
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Row(
          children: [
            Expanded(
              child: TextField(
                decoration:
                    InputDecoration(labelText: "Product name or product code"),
                controller: _ftsController,
                onChanged: (_) => _fetchProducts(),
              ),
            ),
            SizedBox(width: 8),
            DropdownButton<String>(
              value: _selectedSortDirection,
              onChanged: (newValue) {
                setState(() {
                  _selectedSortDirection = newValue!;
                  _fetchProducts();
                });
              },
              items: <String>['ascending', 'descending']
                  .map<DropdownMenuItem<String>>((String value) {
                return DropdownMenuItem<String>(
                  value: value,
                  child: Text(value),
                );
              }).toList(),
            ),
            SizedBox(width: 8),
            ElevatedButton(
              onPressed: () async {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => ProductDetailScreen(
                      product: null,
                    ),
                  ),
                );
              },
              child: Text("Add"),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildDataListView() {
    if (result?.result == null) {
      return Center(
        child: Text('No products found.'),
      );
    }

    return Expanded(
      child: SingleChildScrollView(
        child: DataTable(
          columns: [
            const DataColumn(
              label: const Expanded(
                child: const Text(
                  'Sifra',
                  style: const TextStyle(fontStyle: FontStyle.italic),
                ),
              ),
            ),
            const DataColumn(
              label: const Expanded(
                child: const Text(
                  'Naziv proizvoda',
                  style: const TextStyle(fontStyle: FontStyle.italic),
                ),
              ),
            ),
            const DataColumn(
              label: const Expanded(
                child: const Text(
                  'Cijena',
                  style: const TextStyle(fontStyle: FontStyle.italic),
                ),
              ),
            ),
            const DataColumn(
              label: const Expanded(
                child: const Text(
                  'Slika',
                  style: const TextStyle(fontStyle: FontStyle.italic),
                ),
              ),
            ),
            const DataColumn(
              label: const Expanded(
                child: const Text(''),
              ),
            ),
          ],
          rows: result!.result
              .map(
                (Product e) => DataRow(
                  onSelectChanged: (selected) {
                    if (selected == true) {
                      Navigator.of(context).push(
                        MaterialPageRoute(
                          builder: (context) => ProductDetailScreen(
                            product: e,
                          ),
                        ),
                      );
                    }
                  },
                  cells: [
                    DataCell(Text(e.barcode ?? "")),
                    DataCell(Text(e.productName ?? "")),
                    DataCell(Text(e.productPrice.toString())),
                    DataCell(
                      e.slika != ""
                          ? Container(
                              width: 100,
                              height: 100,
                              child: imageFromBase64String(e.slika!),
                            )
                          : Text(""),
                    ),
                    DataCell(
                      IconButton(
                        icon: Icon(Icons.delete),
                        onPressed: () {
                          _showDeleteConfirmationDialog(e);
                        },
                      ),
                    ),
                  ],
                ),
              )
              .toList(),
        ),
      ),
    );
  }

  void _showDeleteConfirmationDialog(Product e) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Confirm Delete'),
          content: Text('Are you sure you want to delete this item?'),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop();
              },
              child: Text('Cancel'),
            ),
            TextButton(
              onPressed: () async {
                await _deleteProduct(e);
                Navigator.of(context).pop();
              },
              child: Text('Delete'),
            ),
          ],
        );
      },
    );
  }

  Future<void> _deleteProduct(Product product) async {
    try {
      await _productProvider.delete(product.productId);
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Product  deleted successfully.'),
          duration: Duration(seconds: 2),
        ),
      );
      _fetchProducts();
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Failed to delete product.'),
          duration: Duration(seconds: 2),
        ),
      );
    }
  }
}
