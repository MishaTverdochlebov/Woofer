using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime EditedOn { get; set; }
        public Guid PostedByUserId { get; set; }
        //public Guid ArticleId { get; set; }
        //public Guid CommentId { get; set; }
        public PostType? Type { get; set; }

        // virtual props
        public virtual User PostedByUser { get; set; }
        public virtual Article Article { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }
        public Post()
        {
            PostTags = new HashSet<PostTag>();
        }
    }

    public enum PostType
    {
        Entry,
        Article,
        Comment
    }
}
