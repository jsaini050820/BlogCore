using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Models
{
    public class ApplicationUser:IdentityUser
    {
       // public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       // public string UserName { get; set; }
      //  public string Email { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }
      //  public byte[] PasswordHash { get; set; }
    }
}
