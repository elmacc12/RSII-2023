import 'package:edentist_mobile/models/dental_service.dart';
import 'package:edentist_mobile/models/medical_card.dart';
import 'package:edentist_mobile/models/user.dart';
import 'package:edentist_mobile/providers/dental_service_provider.dart';
import 'package:edentist_mobile/providers/medicalCard_provider.dart';
import 'package:edentist_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:collection/collection.dart';

class MedicalCardPage extends StatefulWidget {
  final User user;

  MedicalCardPage({required this.user});

  @override
  _MedicalCardPageState createState() => _MedicalCardPageState();
}

class _MedicalCardPageState extends State<MedicalCardPage> {
  final MedicalCardProvider _medicalCardProvider = MedicalCardProvider();
  final DentalServiceProvider _dentalServiceProvider = DentalServiceProvider();
  List<MedicalCard> medicalCards = [];
  List<DentalService> dentalServices = [];
  bool isLoading = true;

  @override
  void initState() {
    super.initState();
    fetchMedicalRecords();
    fetchDentalServices();
  }

  Future<void> fetchMedicalRecords() async {
    try {
      var result = await _medicalCardProvider.get();
      setState(() {
        medicalCards = result.result;
        isLoading = false;
      });
    } catch (e) {
      print(e);
      setState(() {
        isLoading = false;
      });
    }
  }

  Future<void> fetchDentalServices() async {
    try {
      var result = await _dentalServiceProvider.get();
      setState(() {
        dentalServices = result.result;
        isLoading = false;
      });
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
        title: Text(
          'Pregled kartona ',
          style: TextStyle(color: Colors.white),
        ),
        backgroundColor: Colors.blue,
      ),
      body: SingleChildScrollView(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            // _buildUserImage(),
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: medicalCards
                          .where((mc) => mc.userId == widget.user.userId)
                          .length >
                      0
                  ? Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: medicalCards
                          .where((mc) => mc.userId == widget.user.userId)
                          .map((medicalCard) {
                        DentalService? matchingService =
                            dentalServices.firstWhereOrNull((service) =>
                                service.dentalServiceId ==
                                medicalCard.dentalServiceId);
                        return _buildDiagnosis(
                          serviceName: matchingService?.serviceName ?? "",
                          date: medicalCard.datumDijagnoze.toString() ?? "",
                          doctorsOpinion: medicalCard.doctorsOppinion ?? "",
                        );
                      }).toList())
                  : Text("Nema dostupnih dijagnoza."),
            ),
          ],
        ),
      ),
    );
  }

  // Widget _buildUserImage() {
  //   if (widget.user.slika == null ||
  //       widget.user.slika == "0x" ||
  //       widget.user.slika == "") {
  //     return Container(
  //       height: 120,
  //       width: 120,
  //       color: Colors.grey,
  //       margin: EdgeInsets.all(16),
  //       child: Text("No image",
  //           style: TextStyle(
  //               color: Colors.white, // Set text color to white
  //               fontWeight: FontWeight.bold)),
  //     );
  //   } else {
  //     return Container(
  //       height: 120,
  //       width: 120,
  //       margin: EdgeInsets.all(16),
  //       child: imageFromBase64String(widget.user.slika ?? ""),
  //     );
  //   }
  // }

  Widget _buildDiagnosis({
    required String serviceName,
    required String date,
    required String doctorsOpinion,
  }) {
    return Card(
      elevation: 3,
      margin: EdgeInsets.only(bottom: 8),
      child: Padding(
        padding: const EdgeInsets.all(8.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text('Datum: $date', style: TextStyle(fontWeight: FontWeight.bold)),
            SizedBox(height: 8),
            Text('Naziv dijagnoze: $serviceName'),
            SizedBox(height: 8),
            Text('Mišljenje doktora: $doctorsOpinion'),
          ],
        ),
      ),
    );
  }
}
