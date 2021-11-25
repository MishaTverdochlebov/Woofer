using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class View
    {
        public Guid PostId { get; set; }
        public Guid UserId { get; set; }
        public DateTime ViewedOn { get; set; }
    }
}
