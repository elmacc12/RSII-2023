import 'package:edentist_mobile/models/appointment.dart';
import 'package:edentist_mobile/models/search_result.dart';
import 'package:edentist_mobile/models/user.dart';
import 'package:edentist_mobile/providers/appointment_provider.dart';
import 'package:edentist_mobile/providers/user_provider.dart';
import 'package:edentist_mobile/screens/termin_details_screen.dart';
import 'package:edentist_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import 'package:provider/provider.dart';

class TerminiPage extends StatefulWidget {
  const TerminiPage({Key? key}) : super(key: key);

  @override
  State<TerminiPage> createState() => _TerminiPageState();
}

class _TerminiPageState extends State<TerminiPage> {
  final AppointmentsProvider _terminiProvider = AppointmentsProvider();
  late UserProvider _korisniciProvider;
  List<User>? result;
  List<Appointment> _termin = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    _korisniciProvider = Provider.of<UserProvider>(context, listen: false);
    _fetchData();
  }

  Future<void> _fetchData() async {
    try {
      var userData = await _korisniciProvider.get();
      setState(() {
        result = userData.result;
      });

      final pacijent = result?.firstWhere(
          (korisnik) => korisnik.username == Authorization.username);

      if (pacijent!.userId != null) {
        var appointmentsData = await _terminiProvider.get();
        setState(() {
          _termin = appointmentsData.result
              .where((termin) => termin.userId == pacijent.userId)
              .toList();
          isLoading = false;
        });
      } else {
        setState(() {
          isLoading = false;
        });
      }
    } catch (e) {
      print(e);
      setState(() {
        isLoading = false;
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Appointments', style: TextStyle(color: Colors.white)),
        backgroundColor: Colors.blue,
      ),
      body: Column(
        children: [
          SizedBox(height: 16),
          ElevatedButton(
            onPressed: () async {
              _navigateToTerminDetailScreen(null, null);
            },
            style: ElevatedButton.styleFrom(
              backgroundColor: Colors.blue,
              // onPrimary: Colors.white,
            ),
            child: SizedBox(
              width: double.infinity,
              child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: Text(
                  'Dodaj novi termin',
                  textAlign: TextAlign.center,
                  style: TextStyle(color: Colors.white),
                ),
              ),
            ),
          ),
          SizedBox(height: 16),
          Expanded(
            child: SingleChildScrollView(
              child: Center(child: _buildDataListView()),
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildDataListView() {
    if (isLoading) {
      return CircularProgressIndicator();
    }

    if (_termin.isEmpty) {
      return Text('Nema zakazanih termina');
    }

    return Container(
      width: double.infinity,
      child: Center(
        child: SingleChildScrollView(
          scrollDirection: Axis.horizontal,
          child: DataTable(
            columns: [
              DataColumn(label: Text('Datum')),
              DataColumn(label: Text('Vrijeme')),
              DataColumn(label: Text('Otkaži')),
              DataColumn(label: Text('Uredi')),
            ],
            rows: _termin.map((termin) {
              return DataRow(
                cells: [
                  DataCell(Text(
                      DateFormat('dd.MM.yyyy - HH:mm').format(termin.datum))),
                  DataCell(Text(DateFormat('HH:mm').format(termin.datum))),
                  DataCell(
                    ElevatedButton(
                      onPressed: () {
                        _showDeleteConfirmationDialog(termin);
                      },
                      style:
                          ElevatedButton.styleFrom(backgroundColor: Colors.red),
                      child:
                          Text('Otkaži', style: TextStyle(color: Colors.white)),
                    ),
                  ),
                  DataCell(
                    ElevatedButton(
                      onPressed: () {
                        _navigateToTerminDetailScreen(termin, termin.userId);
                      },
                      style: ElevatedButton.styleFrom(
                          backgroundColor: Colors.blue),
                      child:
                          Text('Uredi', style: TextStyle(color: Colors.white)),
                    ),
                  ),
                ],
              );
            }).toList(),
          ),
        ),
      ),
    );
  }

  void _navigateToTerminDetailScreen(
      Appointment? termin, int? selectedPatient) async {
    final modifiedTermin = await Navigator.of(context).push(
      MaterialPageRoute(
        builder: (context) => AddAppointmentPage(termin: termin),
      ),
    );

    if (modifiedTermin != null && modifiedTermin is Appointment) {
      setState(() {
        int index = _termin.indexWhere(
            (element) => element.appointmentID == modifiedTermin.appointmentID);
        if (index != -1) {
          _termin[index] = modifiedTermin;
        } else {
          _termin.add(modifiedTermin);
        }
      });
    }
  }

  void _showDeleteConfirmationDialog(Appointment termin) {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        return AlertDialog(
          title: Text('Potvrdi otkazivanje'),
          content: Text('Da li želite otkazati dati termin'),
          actions: [
            TextButton(
              onPressed: () {
                Navigator.of(context).pop();
              },
              child: Text('Zadrži termin'),
            ),
            TextButton(
              onPressed: () async {
                await _deleteTermin(termin);
                Navigator.of(context).pop();
              },
              child: Text('Otkaži'),
            ),
          ],
        );
      },
    );
  }

  Future<void> _deleteTermin(Appointment termin) async {
    try {
      await _terminiProvider.delete(termin.appointmentID);
      setState(() {
        _termin
            .removeWhere((item) => item.appointmentID == termin.appointmentID);
      });
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content: Text('Termin "${termin.appointmentID}" je uspješno obrisan'),
        ),
      );
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(
          content:
              Text('Greška pri brisanju termina "${termin.appointmentID}".'),
        ),
      );
    }
  }
}
