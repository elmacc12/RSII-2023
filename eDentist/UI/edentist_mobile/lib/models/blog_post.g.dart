// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'blog_post.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

BlogPost _$BlogPostFromJson(Map<String, dynamic> json) => BlogPost(
      json['blogId'] as int,
      json['headline'] as String?,
      json['content'] as String?,
      json['image'] as String?,
      DateTime.parse(json['createdAt'] as String),
    );

Map<String, dynamic> _$BlogPostToJson(BlogPost instance) => <String, dynamic>{
      'blogId': instance.blogId,
      'headline': instance.headline,
      'content': instance.content,
      'image': instance.image,
      'createdAt': instance.createdAt.toIso8601String(),
    };
