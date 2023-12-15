import 'package:flutter/material.dart';
import '../widgets/blue_button.dart';

class PatientsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Svi pacijenti', style: TextStyle(color: Colors.white)),
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
                  DataColumn(label: Text('Ime i prezime')),
                  DataColumn(label: Text('Pregledaj karton')),
                ],
                rows: [
                  DataRow(
                    cells: [
                      DataCell(Text('Data 1')),
                      // Blue Button
                      DataCell(
                        ElevatedButton(
                          onPressed: () {
                            // Action 1
                          },
                          style: ElevatedButton.styleFrom(
                            primary: Colors.blue,
                          ),
                          child: Text(
                            'Action 1',
                            style: TextStyle(color: Colors.white),
                          ),
                        ),
                      ),
                    ],
                  ),
                  // Add more rows as needed
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
