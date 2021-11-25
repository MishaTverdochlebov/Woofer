using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class Like
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public DateTime LikedOn { get; set; }
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
