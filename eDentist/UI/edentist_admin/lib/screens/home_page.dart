import 'package:eprodaja_admin/screens/blog_screen.dart';
import 'package:eprodaja_admin/screens/dental_service_page.dart';
import 'package:eprodaja_admin/screens/medical_card_page.dart';
import 'package:eprodaja_admin/screens/orders_list_screen.dart';
import 'package:eprodaja_admin/screens/patients_page.dart';
import 'package:eprodaja_admin/screens/products_page.dart';
import 'package:eprodaja_admin/screens/termini_page.dart';
import 'package:flutter/material.dart';
import '../widgets/blue_button.dart';

class HomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Dobrodošli', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Row(
        children: [
          Expanded(
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                BlueButton(
                    text: 'Pregled narudžbi',
                    height: 80.0,
                    width: double.infinity,
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) => OrdersListScreen()),
                      );
                    }),
                BlueButton(
                    text: 'Pregled termina',
                    height: 80.0,
                    width: double.infinity,
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(builder: (context) => TerminiPage()),
                      );
                    }),
                BlueButton(
                    text: 'Pregled lječničkih kartona',
                    height: 80.0,
                    width: double.infinity,
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(builder: (context) => PatientsPage()),
                      );
                    }),
                BlueButton(
                    text: 'Usluge',
                    height: 80.0,
                    width: double.infinity,
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                            builder: (context) => DentalServicesPage()),
                      );
                    }),
                BlueButton(
                    text: 'Pregled proizvoda',
                    height: 80.0,
                    width: double.infinity,
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(builder: (context) => ProductsPage()),
                      );
                    }),
                BlueButton(
                    text: 'Pregled članaka',
                    height: 80.0,
                    width: double.infinity,
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(builder: (context) => BlogListPage()),
                      );
                    }),
              ],
            ),
          ),
          //Logo
          Expanded(
            child: Center(
              child: Image.asset(
                'assets/images/logo.png',
                height: 800,
                width: 800,
              ),
            ),
          ),
        ],
      ),
    );
  }
}
