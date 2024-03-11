// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'recommendResult.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

RecommendResult _$RecommendResultFromJson(Map<String, dynamic> json) =>
    RecommendResult(
      json['Id'] as int,
      json['proizvodId'] as int?,
      json['drugiProizvodId'] as int?,
      json['treciProizvodId'] as int?,
    )..prviProizvodId = json['prviProizvodId'] as int?;

Map<String, dynamic> _$RecommendResultToJson(RecommendResult instance) =>
    <String, dynamic>{
      'Id': instance.Id,
      'proizvodId': instance.proizvodId,
      'prviProizvodId': instance.prviProizvodId,
      'drugiProizvodId': instance.drugiProizvodId,
      'treciProizvodId': instance.treciProizvodId,
    };
