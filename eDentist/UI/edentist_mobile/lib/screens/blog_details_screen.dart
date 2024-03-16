import 'package:edentist_mobile/utils/util.dart';
import 'package:flutter/material.dart';
import 'package:edentist_mobile/models/blog_post.dart';

class BlogDetailsScreen extends StatelessWidget {
  final BlogPost blog;

  const BlogDetailsScreen({Key? key, required this.blog}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Detalji bloga'),
      ),
      body: SingleChildScrollView(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              blog.headline ?? "",
              style: TextStyle(
                fontSize: 24.0,
                fontWeight: FontWeight.bold,
              ),
            ),
            SizedBox(height: 8.0),
            _buildBlogImage(),
            SizedBox(height: 16.0),
            Text(
              blog.content ?? "",
              style: TextStyle(fontSize: 16.0),
            ),
          ],
        ),
      ),
    );
  }

  Widget _buildBlogImage() {
    if (blog.slika == null || blog.slika == "0x" || blog.slika == "") {
      return Container(
        height: 120,
        width: 120,
        color: Colors.grey,
        margin: EdgeInsets.all(16),
        child: Text("No image",
            style: TextStyle(
                color: Colors.white, // Set text color to white
                fontWeight: FontWeight.bold)),
      );
    } else {
      return Container(
        height: 200,
        width: double.infinity,
        margin: EdgeInsets.all(16),
        child: imageFromBase64String(blog.slika!),
      );
    }
  }
}
