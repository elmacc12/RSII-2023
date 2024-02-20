import 'dart:convert';

import 'package:edentist_mobile/models/favorite.dart';

import 'base_provider.dart';

class FavoritesProvider extends BaseProvider<Favorite> {
  String? _mainBaseUrl;
  String _endpoint = "OmiljeniProizvodi";

  FavoritesProvider() : super("Favorites") {
    _mainBaseUrl = const String.fromEnvironment("mainBaseUrl",
        defaultValue: "http://10.0.2.2:7005/");
  }

  Future<bool> exists(int productId) async {
    final favorites = await get(filter: {"proizvodId": productId});
    return favorites.count > 0;
  }

  @override
  Favorite fromJson(data) {
    return Favorite.fromJson(data);
  }

  Future<dynamic> sendRabbit(dynamic object) async {
    var url = "$_mainBaseUrl$_endpoint";

    var uri = Uri.parse(url);
    var jsonRequest = jsonEncode(object);
    var headers = createHeaders();

    var response = await http!.post(uri, headers: headers, body: jsonRequest);

    if (isValidResponse(response)) {
      var data = jsonDecode(response.body);

      return data;
    } else {
      throw Exception("Unknown error");
    }
  }
}
