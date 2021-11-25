using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class PostTag
    {
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }

        public Guid TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
