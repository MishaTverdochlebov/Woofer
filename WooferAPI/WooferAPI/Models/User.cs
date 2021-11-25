using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WooferAPI.Models
{
    public class User : IdentityUser
    {
        public DateTime LastActivity { get; set; }
        public bool IsVerified { get; set; }

        // RegisteredOn

        //virtual props
        public virtual ICollection<Post> Posts { get; set; }
        public User()
        {
            Posts = new List<Post>();
        }
    }
}
