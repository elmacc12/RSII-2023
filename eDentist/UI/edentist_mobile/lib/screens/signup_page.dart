import 'package:edentist_mobile/providers/user_provider.dart';
import 'package:edentist_mobile/screens/product_list_screen.dart';
import 'package:edentist_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:provider/provider.dart';

class SignUpPage extends StatelessWidget {
  SignUpPage({super.key});

  final TextEditingController _firstnameController = TextEditingController();
  final TextEditingController _lastnameController = TextEditingController();
  final TextEditingController _usernameController = TextEditingController();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _addressController = TextEditingController();
  final TextEditingController _passwordController = TextEditingController();
  final TextEditingController _confirmPasswordController =
      TextEditingController();
  final TextEditingController _zipCodeController = TextEditingController();

  late UserProvider _korisniciProvider;

  @override
  Widget build(BuildContext context) {
    _korisniciProvider = Provider.of<UserProvider>(context, listen: false);

    return Scaffold(
      appBar: AppBar(title: const Text("Sign Up")),
      body: Center(
        child: Container(
          constraints: const BoxConstraints(maxHeight: 600, maxWidth: 400),
          child: Card(
            child: Padding(
              padding: const EdgeInsets.all(16.0),
              child: ListView(
                children: [
                  Image.asset(
                    "assets/images/logo.png",
                    height: 150,
                    width: 300,
                  ),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "First Name",
                      prefixIcon: Icon(Icons.person),
                    ),
                    controller: _firstnameController,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Last Name",
                      prefixIcon: Icon(Icons.person),
                    ),
                    controller: _lastnameController,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Username",
                      prefixIcon: Icon(Icons.account_circle),
                    ),
                    controller: _usernameController,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Email",
                      prefixIcon: Icon(Icons.email),
                    ),
                    controller: _emailController,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Address",
                      prefixIcon: Icon(Icons.location_on),
                    ),
                    controller: _addressController,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Zip code",
                      prefixIcon: Icon(Icons.location_on),
                    ),
                    controller: _zipCodeController,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Password",
                      prefixIcon: Icon(Icons.lock),
                    ),
                    controller: _passwordController,
                    obscureText: true,
                  ),
                  const SizedBox(height: 8),
                  TextField(
                    decoration: const InputDecoration(
                      labelText: "Confirm Password",
                      prefixIcon: Icon(Icons.lock),
                    ),
                    controller: _confirmPasswordController,
                    obscureText: true,
                  ),
                  const SizedBox(height: 8),
                  ElevatedButton(
                    onPressed: () async {
                      if (_firstnameController.text.isEmpty ||
                          _lastnameController.text.isEmpty ||
                          _emailController.text.isEmpty ||
                          _addressController.text.isEmpty ||
                          _usernameController.text.isEmpty ||
                          _passwordController.text.isEmpty ||
                          _confirmPasswordController.text.isEmpty ||
                          _confirmPasswordController.text.isEmpty) {
                        showDialog(
                          context: context,
                          builder: (BuildContext context) => AlertDialog(
                            title: const Text("Error"),
                            content: const Text("All fields are required!"),
                            actions: [
                              TextButton(
                                  onPressed: () => Navigator.pop(context),
                                  child: const Text("OK")),
                            ],
                          ),
                        );
                      } else if (_passwordController.text !=
                          _confirmPasswordController.text) {
                        showDialog(
                          context: context,
                          builder: (BuildContext context) => AlertDialog(
                            title: const Text("Error"),
                            content: const Text(
                                "Password needs to match the confirmation password."),
                            actions: [
                              TextButton(
                                  onPressed: () => Navigator.pop(context),
                                  child: const Text("OK")),
                            ],
                          ),
                        );
                      } else if (!RegExp(
                              r"^[a-zA-Z0-9.a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9]+\.[a-zA-Z]+")
                          .hasMatch(_emailController.text)) {
                        showDialog(
                          context: context,
                          builder: (BuildContext context) => AlertDialog(
                            title: const Text("Error"),
                            content: const Text("Incorrect email format."),
                            actions: [
                              TextButton(
                                  onPressed: () => Navigator.pop(context),
                                  child: const Text("OK")),
                            ],
                          ),
                        );
                      } else {
                        Map order = {
                          "roleID": 2,
                          "name": _firstnameController.text,
                          "surname": _lastnameController.text,
                          "email": _emailController.text,
                          "username": _usernameController.text,
                          "adress": _addressController.text,
                          "zipCode": _zipCodeController.text,
                        };

                        var x = await _korisniciProvider.SignUp(order);
                        print(x);
                        if (x != null) {
                          Authorization.username = _usernameController.text;
                          Authorization.password = _passwordController.text;

                          Navigator.of(context).push(
                            MaterialPageRoute(
                                builder: (context) =>
                                    const ProductListScreen()),
                          );
                        }
                      }
                    },
                    child: const Center(child: Text("Sign up")),
                  ),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
