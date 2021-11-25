using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class TestData
    {
        public static void Initialize(WooferDbContext context)
        {

            #region Users

            var user1 = new User { Id = Guid.NewGuid().ToString() };
            var user2 = new User { Id = Guid.NewGuid().ToString() };
            var user3 = new User { Id = Guid.NewGuid().ToString() };
            var user4 = new User { Id = Guid.NewGuid().ToString() };
            var user5 = new User { Id = Guid.NewGuid().ToString() };

            if (!context.Users.Any())
            {
                context.Users.AddRange(user1, user2, user3, user4, user5);
            }
            #endregion Users

            #region Tags

            //var tag1 = new Tag { Id = Guid.NewGuid(), Name = "kuku" };
            //var tag2 = new Tag { Id = Guid.NewGuid(), Name = "lala" };
            //var tag3 = new Tag { Id = Guid.NewGuid(), Name = "ironman" };
            //var tag4 = new Tag { Id = Guid.NewGuid(), Name = "kek" };

            //if (!context.Tags.Any())
            //{
            //    context.Tags.AddRange(tag1, tag2, tag3, tag4);
            //}

            #endregion Tags

            #region Articles

            //var art1 = new Article
            //{
            //    Id = Guid.NewGuid(),
            //    Post = new Post
            //    {
            //        Id = Guid.NewGuid(),
            //        PostedOn = DateTime.Now,
            //        PostedByUser = user1,
            //        Type = PostType.Article,
            //        Tags = new List<Tag> { tag1, tag2, tag3 },
            //    },
            //    Topic = "Kuku Ironman",
            //    Content = "La La La la"
            //};
            //var art2 = new Article
            //{
            //    Id = Guid.NewGuid(),
            //    Post = new Post
            //    {
            //        Id = Guid.NewGuid(),
            //        PostedOn = DateTime.Now,
            //        PostedByUser = user2,
            //        Type = PostType.Article,
            //        Tags = new List<Tag> { tag3, tag4 },
            //    },
            //    Topic = "Kek Ironman",
            //    Content = "La La La la 2"
            //};
            //var art3 = new Article
            //{
            //    Id = Guid.NewGuid(),
            //    Post = new Post
            //    {
            //        Id = Guid.NewGuid(),
            //        PostedOn = DateTime.Now,
            //        PostedByUser = user4,
            //        Type = PostType.Article,
            //        Tags = new List<Tag> { tag4, tag2, tag1 },
            //    },
            //    Topic = "Lala Ironman",
            //    Content = "La La La la 3"
            //};
            //if (!context.Articles.Any())
            //{
            //    context.Articles.AddRange(art1, art2, art3);
            //}
            #endregion Articles

            #region Comments

            //var com1 = new Comment
            //{
            //    Id = Guid.NewGuid(),
            //    Post = new Post
            //    {
            //        Id = Guid.NewGuid(),
            //        PostedOn = DateTime.Now,
            //        PostedByUser = user3,
            //        Type = PostType.Comment,
            //    },
            //    CommentedPost = art1.Post,
            //    Content = "eto ne kuku, eto rofl"
            //};
            //var com2 = new Comment
            //{
            //    Id = Guid.NewGuid(),
            //    Post = new Post
            //    {
            //        Id = Guid.NewGuid(),
            //        PostedOn = DateTime.Now,
            //        PostedByUser = user3,
            //        Type = PostType.Comment,
            //    },
            //    CommentedPost = art2.Post,
            //    Content = "mama gde?"
            //};
            //var com3 = new Comment
            //{
            //    Id = Guid.NewGuid(),
            //    Post = new Post
            //    {
            //        Id = Guid.NewGuid(),
            //        PostedOn = DateTime.Now,
            //        PostedByUser = user3,
            //        Type = PostType.Comment,
            //    },
            //    CommentedPost = art3.Post,
            //    Content = "eto uzhe kuku ^_^"
            //};

            //if (!context.Comments.Any())
            //{
            //    context.Comments.AddRange(com1, com2, com3);
            //}
            #endregion Comments

            #region Likes

            //var like1 = new Like { Post = art1.Post, User = user1 };
            //var like2 = new Like { Post = art2.Post, User = user1 };
            //var like3 = new Like { Post = art3.Post, User = user1 };
            //var like4 = new Like { Post = art1.Post, User = user2 };
            //var like5 = new Like { Post = com1.Post, User = user1 };
            //var like6 = new Like { Post = com3.Post, User = user4 };

            //if (!context.Likes.Any())
            //{
            //    context.Likes.AddRange(like1, like2, like3, like4, like5, like6);
            //}
            #endregion Likes

            context.SaveChanges();
        }
    }
}
