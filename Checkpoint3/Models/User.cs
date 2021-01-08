using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint3.Models
{
    public class User : IdentityUser
    {
        public Int32 UserId { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String City { get; set; }
        public String Email { get; set; }
    }
}
