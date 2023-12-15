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
                    width: double.infinity),
                BlueButton(
                    text: 'Pregled termina',
                    height: 80.0,
                    width: double.infinity),
                BlueButton(
                    text: 'Pregled lječničkih kartona',
                    height: 80.0,
                    width: double.infinity),
                BlueButton(
                    text: 'Usluge', height: 80.0, width: double.infinity),
                BlueButton(
                    text: 'Pregled proizvoda',
                    height: 80.0,
                    width: double.infinity),
                BlueButton(
                    text: 'Dodaj članak', height: 80.0, width: double.infinity),
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
