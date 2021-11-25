using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PostTag> PostTags { get; set; }

        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }
    }
}
