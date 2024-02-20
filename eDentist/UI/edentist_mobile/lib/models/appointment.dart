import 'package:json_annotation/json_annotation.dart';

part "appointment.g.dart";

@JsonSerializable()
class Appointment {
  int? appointmentID;
  int? userId;
  DateTime datum;
  String? vrijeme;
  bool terminZatvoren;
  Appointment(this.appointmentID, this.userId, this.datum, this.vrijeme,
      this.terminZatvoren);

  factory Appointment.fromJson(Map<String, dynamic> json) =>
      _$AppointmentFromJson(json);
  Map<String, dynamic> toJson() => _$AppointmentToJson(this);
}
