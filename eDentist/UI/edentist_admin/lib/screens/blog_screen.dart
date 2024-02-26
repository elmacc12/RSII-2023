import 'package:flutter/material.dart';
import 'package:eprodaja_admin/models/blog_post.dart';
import 'package:eprodaja_admin/providers/blog_post_provider.dart';
import 'package:provider/provider.dart';
import 'blog_details_screen.dart';

class BlogListPage extends StatefulWidget {
  const BlogListPage({Key? key}) : super(key: key);

  @override
  _BlogListPageState createState() => _BlogListPageState();
}

class _BlogListPageState extends State<BlogListPage> {
  late BlogPostProvider _blogProvider;
  List<BlogPost> blogs = [];

  @override
  void initState() {
    super.initState();
    _blogProvider = Provider.of<BlogPostProvider>(context, listen: false);
    _fetchBlogs();
  }

  Future<void> _fetchBlogs() async {
    try {
      var fetchedBlogs = await _blogProvider.get();

      setState(() {
        blogs = fetchedBlogs.result;
      });
    } catch (e) {
      print(e);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Blog List'),
      ),
      body: Column(
        children: [
          ElevatedButton(
            style: ElevatedButton.styleFrom(
              backgroundColor: Colors.blue,
            ),
            onPressed: () {
              Navigator.of(context).push(MaterialPageRoute(
                builder: (context) => BlogDetailsScreen(
                  post: null,
                ),
              ));
              _fetchBlogs();
            },
            child: Text(
              "Add",
              style: TextStyle(color: Colors.white),
            ),
          ),
          Expanded(
            child: _buildBlogList(),
          ),
        ],
      ),
    );
  }

  Widget _buildBlogList() {
    if (blogs.isEmpty) {
      return Center(
        child: Text('No blogs available.'),
      );
    }

    return ListView.builder(
      itemCount: blogs.length,
      itemBuilder: (context, index) {
        return _buildBlogCard(blogs[index]);
      },
    );
  }

  Widget _buildBlogCard(BlogPost blog) {
    return Card(
      margin: EdgeInsets.all(8.0),
      elevation: 4.0,
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.stretch,
        children: [
          // Display Title
          ListTile(
            title: Text(blog.headline ?? " "),
            onTap: () {
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) => BlogDetailsScreen(post: blog),
                ),
              );
            },
            // Add more widgets to display other blog details as needed
          ),
        ],
      ),
    );
  }
}
