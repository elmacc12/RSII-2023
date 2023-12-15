import 'package:flutter/material.dart';

class BlueButton extends StatelessWidget {
  final String text;
  final double height;
  final double width;

  BlueButton({
    required this.text,
    required this.height,
    required this.width,
  });

  @override
  Widget build(BuildContext context) {
    return Container(
      margin: EdgeInsets.all(8.0),
      height: height,
      width: width,
      child: ElevatedButton(
        onPressed: () {
          // Button action
        },
        style: ElevatedButton.styleFrom(
          primary: Colors.blue,
        ),
        child: Text(
          text,
          style: TextStyle(fontSize: 18, color: Colors.white),
        ),
      ),
    );
  }
}
