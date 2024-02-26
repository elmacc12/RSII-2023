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
        title: Text('Blog Details'),
      ),
      body: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            // Display Heading
            Text(
              blog.headline ?? "",
              style: TextStyle(
                fontSize: 24.0,
                fontWeight: FontWeight.bold,
              ),
            ),
            SizedBox(height: 8.0),
            // Display Image
            blog.image != null
                ? imageFromBase64String(blog.image ?? "")
                : Container(),
            SizedBox(height: 16.0),
            // Display Content
            Text(
              blog.content ?? "",
              style: TextStyle(fontSize: 16.0),
            ),
          ],
        ),
      ),
    );
  }
}
