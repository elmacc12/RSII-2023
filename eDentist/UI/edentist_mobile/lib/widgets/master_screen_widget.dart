// ignore_for_file: prefer_const_constructors
import 'package:edentist_mobile/screens/blog_list_screen.dart';
import 'package:edentist_mobile/screens/cart_screen.dart';
import 'package:edentist_mobile/screens/favorites_screen.dart';
import 'package:edentist_mobile/screens/termini_page.dart';
import 'package:flutter/material.dart';

class MasterScreenWidget extends StatefulWidget {
  Widget? child;
  String? title;
  Widget? titleWidget;

  MasterScreenWidget({this.child, this.title, this.titleWidget, Key? key})
      : super(key: key);

  @override
  State<MasterScreenWidget> createState() => _MasterScreenWidgetState();
}

class _MasterScreenWidgetState extends State<MasterScreenWidget> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: widget.titleWidget ?? Text(widget.title ?? ""),
        actions: [
          IconButton(
            icon: Icon(
              Icons.favorite,
              color: Colors.black,
            ),
            onPressed: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) => FavoritesScreen(),
                ),
              );
            },
          ),
          IconButton(
            icon: Icon(
              Icons.shopping_cart,
              color: Colors.black,
            ),
            onPressed: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) => CartScreen(),
                ),
              );
            },
          ),
        ],
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            DrawerHeader(
              decoration: BoxDecoration(
                color: Colors.blue,
              ),
              child: Text(
                'Navigation',
                style: TextStyle(
                  color: Colors.white,
                  fontSize: 24,
                ),
              ),
            ),
            ListTile(
              title: Text('Termini'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => TerminiPage(),
                  ),
                );
              },
            ),
            ListTile(
              title: Text('Blog'),
              onTap: () {
                Navigator.of(context).push(
                  MaterialPageRoute(
                    builder: (context) => BlogListPage(),
                  ),
                );
              },
            ),
            ListTile(
              title: Text('Odjavi se'),
              onTap: () {
                // Log out
                Navigator.pop(context);
                // Add your navigation logic here
              },
            ),
          ],
        ),
      ),
      body: widget.child,
    );
  }
}
