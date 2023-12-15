import 'package:flutter/material.dart';
import '../widgets/blue_button.dart';

class TerminiPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Pregled termina', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          // Blue Button
          Container(
              margin: EdgeInsets.all(8.0),
              child:
                  BlueButton(text: 'Dodaj termin', height: 50.0, width: 100.0)),
          // Table
          Expanded(
            child: SingleChildScrollView(
              child: DataTable(
                columns: [
                  DataColumn(label: Text('Vrijeme termina')),
                  DataColumn(label: Text('Pacijent')),
                  DataColumn(label: Text('Usluga')),
                  DataColumn(label: Text('Pregledaj detalje')),
                  DataColumn(label: Text('Otkaži termin')),
                ],
                rows: [
                  DataRow(
                    cells: [
                      DataCell(Text('Data 1')),
                      DataCell(Text('Data 2')),
                      DataCell(Text('Data 3')),
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
                      // Red Button
                      DataCell(
                        ElevatedButton(
                          onPressed: () {
                            // Action 2
                          },
                          style: ElevatedButton.styleFrom(
                            primary: Colors.red,
                          ),
                          child: Text(
                            'Action 2',
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
