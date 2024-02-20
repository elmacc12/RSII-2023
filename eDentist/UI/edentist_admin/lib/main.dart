import 'package:eprodaja_admin/providers/appointments_provider.dart';
import 'package:eprodaja_admin/providers/color_prvider.dart';
import 'package:eprodaja_admin/providers/dentalService_provider.dart';
import 'package:eprodaja_admin/providers/login_provider.dart';
import 'package:eprodaja_admin/providers/product_provider.dart';
import 'package:eprodaja_admin/providers/product_type_provider.dart';
import 'package:eprodaja_admin/providers/user_provider.dart';
import 'package:eprodaja_admin/screens/dental_service_page.dart';

import './screens/termini_page.dart';
import 'package:flutter/material.dart';
import './screens/login_page.dart';
import 'package:provider/provider.dart';
import 'package:timezone/data/latest.dart' as tz;
import 'package:timezone/timezone.dart' as tz;

void main() {
  WidgetsFlutterBinding.ensureInitialized();
  tz.initializeTimeZones();
  tz.setLocalLocation(tz.getLocation('Europe/Belgrade'));
  runApp(MyMaterialApp());
}

class OrderDetailState extends ChangeNotifier {
  Map<String, dynamic>? _orderDetails;

  Map<String, dynamic>? get orderDetails => _orderDetails;

  void updateOrderDetails(Map<String, dynamic> newOrderDetails) {
    _orderDetails = Map<String, dynamic>.from(newOrderDetails);
    notifyListeners();
  }
}

class ProductDetailState extends ChangeNotifier {
  Map<String, dynamic>? _productDetails;

  Map<String, dynamic>? get productDetails => _productDetails;

  void updateProductDetails(Map<String, dynamic> newProductDetails) {
    _productDetails = Map<String, dynamic>.from(newProductDetails);
    notifyListeners();
  }
}

class MyMaterialApp extends StatelessWidget {
  const MyMaterialApp({super.key});

  @override
  Widget build(BuildContext context) {
    return MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => LogInProvider()),
        ChangeNotifierProvider(create: (_) => DentalServiceProvider()),
        ChangeNotifierProvider(create: (_) => ProductProvider()),
        ChangeNotifierProvider(create: (_) => AppointmentsProvider()),
        ChangeNotifierProvider(create: (_) => UserProvider()),
        ChangeNotifierProvider(create: (_) => ColorProvider()),
        ChangeNotifierProvider(create: (_) => ProductTypeProvider()),
        ChangeNotifierProvider(create: (_) => ProductDetailState()),
      ],
      child: MaterialApp(
        title: 'RS II Material app',
        theme: ThemeData(primarySwatch: Colors.blue),
        home: LoginPage(),
      ),
    );
  }
}
