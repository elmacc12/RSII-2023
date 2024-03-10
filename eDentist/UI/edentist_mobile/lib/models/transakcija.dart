import 'dart:ffi';

import 'package:json_annotation/json_annotation.dart';

part "transakcija.g.dart";

@JsonSerializable()
class Transakcija {
  int? transkcijaId;
  int? orderHeaderId;
  int? amount;
  String? transactionStatus;
  String? transId;
  Transakcija(this.transkcijaId, this.orderHeaderId, this.amount,
      this.transactionStatus, this.transId);

  factory Transakcija.fromJson(Map<String, dynamic> json) =>
      _$TransakcijaFromJson(json);
  Map<String, dynamic> toJson() => _$TransakcijaToJson(this);
}
