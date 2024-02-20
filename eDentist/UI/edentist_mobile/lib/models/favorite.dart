import 'package:json_annotation/json_annotation.dart';

part 'favorite.g.dart';

@JsonSerializable()
class Favorite {
  int userId;
  int productId;

  Favorite(this.userId, this.productId);

  factory Favorite.fromJson(Map<String, dynamic> json) =>
      _$FavoriteFromJson(json);

  Map<String, dynamic> toJson() => _$FavoriteToJson(this);
}
