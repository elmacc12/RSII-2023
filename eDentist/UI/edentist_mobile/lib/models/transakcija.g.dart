// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'transakcija.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Transakcija _$TransakcijaFromJson(Map<String, dynamic> json) => Transakcija(
      json['transkcijaId'] as int?,
      json['orderHeaderId'] as int?,
      json['amount'] as int?,
      json['transactionStatus'] as String?,
      json['transId'] as String?,
    );

Map<String, dynamic> _$TransakcijaToJson(Transakcija instance) =>
    <String, dynamic>{
      'transkcijaId': instance.transkcijaId,
      'orderHeaderId': instance.orderHeaderId,
      'amount': instance.amount,
      'transactionStatus': instance.transactionStatus,
      'transId': instance.transId,
    };
