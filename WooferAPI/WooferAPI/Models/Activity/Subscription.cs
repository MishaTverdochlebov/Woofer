using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class Subscription
    {
        public Guid SubscriberId { get; set; }
        public Guid SubObjectId { get; set; }
        public DateTime SubscribedOn { get; set; }
        public virtual User Subscriber { get; set; }
        public virtual User SubObject { get; set; }
    }
}
