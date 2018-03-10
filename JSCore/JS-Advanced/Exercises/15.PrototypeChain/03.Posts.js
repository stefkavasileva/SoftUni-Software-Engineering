function getPosts() {
    class Post {
        constructor(title, content) {
            this.title = title;
            this.content = content;
        }

        toString() {
            let result = `Post: ${this.title}\nContent: ${this.content}`;
            return result;
        }
    }

    class SocialMediaPost extends Post {
        constructor(title, content, likes, dislikes) {
            super(title, content);
            this.likes = likes;
            this.dislikes = dislikes;
            this.comments = [];
        }

        addComment(comment) {
            this.comments.push(comment)
        }

        toString(){
            let result =  super.toString() + `\nRating: ${this.likes - this.dislikes}`;
            if(this.comments.length > 0){
                result += "\nComments:";
                this.comments.forEach(x => result += `\n * ${x}`);
            }

            return result;
        }
    }

    class BlogPost extends Post{
        constructor(title, content,views){
            super(title,content);
            this.views = views;
        }

        view(){
            this.views++;
            return this;
        }

        toString(){
            let result = super.toString() + `\nViews: ${this.views}`;
            return result;
        }
    }

    return {Post,SocialMediaPost,BlogPost};
}

let posts = getPosts();
let Post = posts.Post;
let SocialMediaPost = posts.SocialMediaPost;
let BlogPost = posts.BlogPost;


let post = new Post("Post", "Content");

console.log(post.toString());

// Post: Post
// Content: Content

let scm = new SocialMediaPost("TestTitle", "TestContent", 25, 30);

scm.addComment("Good post");
scm.addComment("Very good post");
scm.addComment("Wow!");

console.log(scm.toString());

// Post: TestTitle
// Content: TestContent
// Rating: -5
// Comments:
//  * Good post
//  * Very good post
//  * Wow!

let blog = new BlogPost("TestTitle", "TestContent", 5);
console.log(blog.toString());