// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User(
      json['userId'] as int,
      json['roleID'] as int,
      json['name'] as String?,
      json['surname'] as String?,
      json['email'] as String?,
      json['username'] as String?,
      json['adress'] as String?,
      json['zipCode'] as String?,
      json['cityId'] as int,
      json['slika'] as String?,
    );

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'userId': instance.userId,
      'roleID': instance.roleID,
      'name': instance.name,
      'surname': instance.surname,
      'email': instance.email,
      'username': instance.username,
      'adress': instance.adress,
      'zipCode': instance.zipCode,
      'cityId': instance.cityId,
      'slika': instance.slika,
    };
