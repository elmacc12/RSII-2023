// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'order_detail.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Order _$OrderFromJson(Map<String, dynamic> json) => Order(
      json['productId'] as int?,
      json['quantity'] as int?,
    );

Map<String, dynamic> _$OrderToJson(Order instance) => <String, dynamic>{
      'productId': instance.productId,
      'quantity': instance.quantity,
    };
