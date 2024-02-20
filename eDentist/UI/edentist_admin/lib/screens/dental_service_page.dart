import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import '../models/dental_service.dart';
import '../providers/dentalService_provider.dart';
import '../widgets/blue_button.dart';

class DentalServicesPage extends StatefulWidget {
  @override
  _DentalServicesPageState createState() => _DentalServicesPageState();
}

class _DentalServicesPageState extends State<DentalServicesPage> {
  final DentalServiceProvider _dentalServiceProvider = DentalServiceProvider();
  List<DentalService> dentalServices = [];
  bool isLoading = true;
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  String searchInput = "";
  bool isEditing = false;
  int editingServiceIndex = -1;

  @override
  void initState() {
    super.initState();
    fetchData();
  }

  Future<void> fetchData() async {
    try {
      var result = await _dentalServiceProvider.get();
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
    List<DentalService> filteredServices = dentalServices
        .where((service) =>
            (service.serviceName
                    ?.toLowerCase()
                    .contains(searchInput.toLowerCase()) ??
                false) ||
            (service.serviceDescription
                    ?.toLowerCase()
                    .contains(searchInput.toLowerCase()) ??
                false))
        .toList();

    return Scaffold(
      appBar: AppBar(
        title: Text('Usluge', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: Row(
              children: [
                Expanded(
                  child: TextField(
                    decoration: InputDecoration(
                      hintText: 'Search',
                      prefixIcon: Icon(Icons.search),
                    ),
                    onChanged: (value) {
                      setState(() {
                        searchInput = value;
                      });
                    },
                  ),
                ),
                SizedBox(width: 8),
                BlueButton(
                  text: 'Dodaj uslugu',
                  width: 120,
                  height: 40,
                  onPressed: () {
                    _showAddServiceDialog();
                  },
                ),
              ],
            ),
          ),
          Expanded(
            child: SingleChildScrollView(
              child: DataTable(
                columns: [
                  DataColumn(label: Text('Naziv usluge')),
                  DataColumn(label: Text('Opis')),
                  DataColumn(label: Text('Cijena')),
                  DataColumn(label: Text('Uredi')),
                ],
                rows: filteredServices.map((service) {
                  return DataRow(
                    cells: [
                      DataCell(Text(service.serviceName ?? "")),
                      DataCell(Text(service.serviceDescription ?? "")),
                      DataCell(Text(service.servicePrice.toString() + "KM")),
                      DataCell(
                        BlueButton(
                          text: "Uredi",
                          width: 80,
                          height: 40,
                          onPressed: () {
                            _showAddServiceDialog(
                                editing: true, service: service);
                          },
                        ),
                      ),
                    ],
                  );
                }).toList(),
              ),
            ),
          ),
        ],
      ),
    );
  }

  Future<void> _showAddServiceDialog(
      {bool editing = false, DentalService? service}) async {
    isEditing = editing;
    if (editing) {
      editingServiceIndex = dentalServices.indexOf(service!);
    }

    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text(editing ? 'Uredi uslugu' : 'Dodaj uslugu'),
          content: _buildAddServiceForm(service: service),
        );
      },
    );
  }

  Widget _buildAddServiceForm({DentalService? service}) {
    TextEditingController serviceNameController =
        TextEditingController(text: service?.serviceName ?? "");
    TextEditingController serviceDescriptionController =
        TextEditingController(text: service?.serviceDescription ?? "");
    TextEditingController servicePriceController =
        TextEditingController(text: service?.servicePrice?.toString() ?? "");

    return Form(
      key: _formKey,
      child: Column(
        children: [
          TextFormField(
            controller: serviceNameController,
            decoration: InputDecoration(labelText: 'Naziv usluge'),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Unesite naziv usluge';
              }
              return null;
            },
          ),
          TextFormField(
            controller: serviceDescriptionController,
            decoration: InputDecoration(labelText: 'Opis usluge'),
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Unesite opis usluge';
              }
              return null;
            },
          ),
          TextFormField(
            controller: servicePriceController,
            decoration: InputDecoration(labelText: 'Cijena usluge'),
            keyboardType: TextInputType.number,
            validator: (value) {
              if (value == null || value.isEmpty) {
                return 'Unesite cijenu usluge';
              }
              try {
                int.parse(value);
              } catch (e) {
                return 'Provjerite cijenu';
              }
              return null;
            },
          ),
          ElevatedButton(
            onPressed: () async {
              if (_formKey.currentState?.validate() ?? false) {
                var request = {
                  'serviceName': serviceNameController.text,
                  'serviceDescription': serviceDescriptionController.text,
                  'servicePrice': int.parse(servicePriceController.text),
                };

                try {
                  if (isEditing) {
                    await _dentalServiceProvider.update(
                        dentalServices[editingServiceIndex].dentalServiceId!,
                        request);
                  } else {
                    await _dentalServiceProvider.insert(request);
                  }

                  await fetchData();
                  Navigator.pop(context);
                  ScaffoldMessenger.of(context).showSnackBar(
                    SnackBar(
                      content: Text(
                          'Dental service ${isEditing ? 'updated' : 'added'} successfully.'),
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
}
