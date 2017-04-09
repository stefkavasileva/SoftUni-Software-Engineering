using System;
using System.Collections.Generic;
using System.Linq;

public class SocialMediaPosts
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var posts = new List<Post>();

        while (!inputLine.Equals("drop the media"))
        {
            var tokens = inputLine.Split();

            if (tokens[0].Equals("post"))
            {
                if (!posts.Any(p => p.Name == tokens[1]))
                {
                    var newPot = new Post { Name = tokens[1], Comments = new List<Comment>() };
                    posts.Add(newPot);
                }
            }
            else if (tokens[0].Equals("like"))
            {
                var post = posts.Where(p => p.Name == tokens[1]).First();
                post.Likes++;
            }
            else if (tokens[0].Equals("dislike"))
            {
                var post = posts.Where(p => p.Name == tokens[1]).First();
                post.Dislike++;
            }
            else
            {
                var comment = new Comment { CommentatorName = tokens[2], Content = string.Join(" ", tokens.Skip(3)) };
                var post = posts.Where(p => p.Name == tokens[1]).First();
                post.Comments.Add(comment);
            }

            inputLine = Console.ReadLine();
        }

        foreach (var post in posts)
        {
            PrintPost(post);
        }

        //=====================Solution with Dictionary==================//
        //var inputLine = Console.ReadLine();
        //var postLikeDisLike = new Dictionary<string, List<int>>();
        //var postComments = new Dictionary<string, List<string>>();

        //while (!inputLine.Equals("drop the media"))
        //{
        //    var tokens = inputLine.Split().ToArray();
        //    var postName = tokens[1];

        //    if (!tokens[0].Equals("comment"))
        //    {
        //        if (!postLikeDisLike.ContainsKey(postName))
        //        {
        //            postLikeDisLike.Add(postName, new List<int>());
        //            postLikeDisLike[postName].Add(0);
        //            postLikeDisLike[postName].Add(0);
        //        }

        //        if (tokens[0].Equals("like"))
        //        {
        //            postLikeDisLike[postName][0]++;
        //        }
        //        else if (tokens[0].Equals("dislike"))
        //        {
        //            postLikeDisLike[postName][1]++;
        //        }
        //    }
        //    else
        //    {
        //        if (!postComments.ContainsKey(postName))
        //        {
        //            postComments.Add(postName, new List<string>());
        //        }

        //        postComments[postName].Add(tokens[2]);
        //        postComments[postName].Add(string.Join(" ", tokens.Skip(3)));
        //    }

        //    inputLine = Console.ReadLine();
        //}

        //foreach (var post in postLikeDisLike)
        //{
        //    Console.WriteLine($"Post: {post.Key} | Likes: {post.Value[0]} | Dislikes: {post.Value[1]}");

        //    Console.WriteLine("Comments:");
        //    if (!postComments.ContainsKey(post.Key))
        //    {
        //        Console.WriteLine("None");
        //        continue;
        //    }

        //    var comments = postComments[post.Key].ToList();

        //    for (int i = 0; i < comments.Count - 1; i+=2)
        //    {
        //        Console.WriteLine($"*  {comments[i]}: {comments[i+1]}");
        //    }  
        //}
    }

    public static void PrintPost(Post post)
    {
        Console.WriteLine($"Post: {post.Name} | Likes: {post.Likes} | Dislikes: {post.Dislike}");
        Console.WriteLine("Comments:");

        if (post.Comments.Count == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (var comment in post.Comments)
            {
                Console.WriteLine($"*  {comment.CommentatorName}: {comment.Content}");
            }
        }
    }
}