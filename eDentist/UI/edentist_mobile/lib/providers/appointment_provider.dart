import 'dart:convert';
import 'package:http/http.dart' as http;
import 'package:edentist_mobile/models/appointment.dart';
import 'base_provider.dart';

class AppointmentsProvider extends BaseProvider<Appointment> {
  AppointmentsProvider() : super("Appointments");

  @override
  Appointment fromJson(data) {
    return Appointment.fromJson(data);
  }

  Future<void> postAppointment(Appointment appointment) async {
    try {
      final url = Uri.parse('http://10.0.2.2:7005/Appointments');
      final response = await http.post(
        url,
        body: jsonEncode(appointment.toJson()),
        headers: {
          'Content-Type': 'application/json',
        },
      );

      if (response.statusCode == 200) {
        print('Termin uspjesno dodan.');
      } else {
        throw Exception('Greska sa dodavanjem termina.');
      }
    } catch (e) {
      print('Greska sa postavljanjem termina: $e');
      throw Exception('Greska sa postavljanjem termina: $e');
    }
  }
}
