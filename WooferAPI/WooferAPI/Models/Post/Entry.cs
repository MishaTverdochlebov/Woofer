using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class Entry
    {
        public Guid Id { get; set; }
        public Guid PostId { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }
        public virtual Post Post { get; set; }
    }
}
