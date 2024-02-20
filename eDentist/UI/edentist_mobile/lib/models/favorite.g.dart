// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'favorite.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Favorite _$FavoriteFromJson(Map<String, dynamic> json) => Favorite(
      json['userId'] as int,
      json['productId'] as int,
    );

Map<String, dynamic> _$FavoriteToJson(Favorite instance) => <String, dynamic>{
      'userId': instance.userId,
      'productId': instance.productId,
    };
