using System.Collections.Generic;

public class Post
{
    public string Name { get; set; }

    public int Likes { get; set; }

    public int Dislike { get; set; }

    public List<Comment> Comments { get; set; }
}
