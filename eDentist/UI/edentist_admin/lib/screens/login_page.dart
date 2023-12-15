import 'package:eprodaja_admin/providers/color_prvider.dart';
import 'package:flutter/material.dart';
import 'home_page.dart';
import '../utils/util.dart';
import 'package:provider/provider.dart';

class LoginPage extends StatelessWidget {
  LoginPage({Key? key}) : super(key: key);

  TextEditingController _usernameController = new TextEditingController();
  TextEditingController _passwordController = new TextEditingController();
  late ColorProvider _colorProvider;

  @override
  Widget build(BuildContext context) {
    _colorProvider = context.read<ColorProvider>();

    return Scaffold(
      body: Container(
        decoration: BoxDecoration(
          image: DecorationImage(
            image: AssetImage("assets/images/background_image.jpg"),
            fit: BoxFit.cover,
          ),
        ),
        child: Center(
          child: Container(
            constraints: BoxConstraints(maxWidth: 400, maxHeight: 400),
            child: Card(
              child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: Column(children: [
                  Image.asset(
                    "assets/images/logo.png",
                    height: 150,
                    width: 150,
                  ),
                  TextField(
                    decoration: InputDecoration(
                        labelText: "Username", prefixIcon: Icon(Icons.email)),
                    controller: _usernameController,
                  ),
                  SizedBox(
                    height: 8,
                  ),
                  TextField(
                    decoration: InputDecoration(
                        labelText: "Password",
                        prefixIcon: Icon(Icons.password)),
                    controller: _passwordController,
                  ),
                  SizedBox(
                    height: 8,
                  ),
                  ElevatedButton(
                      onPressed: () async {
                        var username = _usernameController.text;
                        var password = _passwordController.text;
                        _passwordController.text = username;

                        print("login proceed $username $password");

                        Authorization.username = username;
                        Authorization.password = password;

                        try {
                          await _colorProvider.get();

                          Navigator.of(context).push(
                            MaterialPageRoute(
                              builder: (context) => HomePage(),
                            ),
                          );
                        } on Exception catch (e) {
                          showDialog(
                              context: context,
                              builder: (BuildContext context) => AlertDialog(
                                    title: Text("Error"),
                                    content: Text(e.toString()),
                                    actions: [
                                      TextButton(
                                          onPressed: () =>
                                              Navigator.pop(context),
                                          child: Text("OK"))
                                    ],
                                  ));
                        }
                      },
                      child: Text("Login"))
                ]),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
