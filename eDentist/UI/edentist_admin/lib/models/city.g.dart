// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'city.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

City _$CityFromJson(Map<String, dynamic> json) => City(
      json['cityId'] as int,
      json['cityName'] as String?,
      json['zipCode'] as String?,
    );

Map<String, dynamic> _$CityToJson(City instance) => <String, dynamic>{
      'cityId': instance.cityId,
      'cityName': instance.cityName,
      'zipCode': instance.zipCode,
    };
