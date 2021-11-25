using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public Guid CommentedPostId { get; set; }
        public string Content { get; set; }
        public virtual Post CommentedPost { get; set; }
        public virtual Post Post { get; set; }
        //public Guid ContentId { get; set; }
    }
}
