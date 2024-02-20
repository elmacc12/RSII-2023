import 'package:eprodaja_admin/models/user.dart';

import 'base_provider.dart';
import '../models/product.dart';

class UserProvider extends BaseProvider<User> {
  UserProvider() : super("Users");

  @override
  User fromJson(data) {
    return User.fromJson(data);
  }
}
