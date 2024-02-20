import 'package:eprodaja_admin/models/dental_service.dart';
import 'package:eprodaja_admin/models/user.dart';
import 'package:eprodaja_admin/providers/dentalService_provider.dart';
import 'package:eprodaja_admin/providers/user_provider.dart';
import 'package:eprodaja_admin/screens/medical_card_page.dart';
import 'package:flutter/material.dart';
import '../widgets/blue_button.dart'; // Assuming you have this widget

// Import your DentalService class and JSON builder here

class PatientsPage extends StatefulWidget {
  @override
  _PatientsPageState createState() => _PatientsPageState();
}

class _PatientsPageState extends State<PatientsPage> {
  final UserProvider _userProvider = UserProvider();

  List<User> users = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    // Call your method to fetch dental services here
    fetchData();
  }

  Future<void> fetchData() async {
    try {
      var result = await _userProvider.get();
      print(result.result);
      setState(() {
        users = result.result;
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
        title: Text('Pacijenti', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          // Search Field
          Padding(
            padding: const EdgeInsets.all(8.0),
            child: TextField(
              decoration: InputDecoration(
                hintText: 'Search',
                prefixIcon: Icon(Icons.search),
              ),
              onChanged: (value) {
                // Implement your search logic here
                // You may want to update the DataTable based on the search input
              },
            ),
          ),
          // Table
          Expanded(
            child: SingleChildScrollView(
              child: DataTable(
                columns: [
                  DataColumn(label: Text('Ime')),
                  DataColumn(label: Text('Prezime')),
                  DataColumn(label: Text('Uredi')),
                ],
                rows: users.where((e) => e.roleID == 2).map((u) {
                  return DataRow(
                    cells: [
                      DataCell(Text(u.name ?? "")),
                      DataCell(Text(u.surname ?? "")),
                      // Blue Button
                      DataCell(
                        BlueButton(
                          text: "Pregledaj",
                          width: double.infinity,
                          height: 80,
                          onPressed: () {
                            Navigator.push(
                              context,
                              MaterialPageRoute(
                                builder: (context) => MedicalCardPage(user: u),
                              ),
                            );
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
}
