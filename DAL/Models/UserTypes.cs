using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class UserTypes
    {
        public UserTypes()
        {
            User = new HashSet<User>();
            UserLibrary = new HashSet<UserLibrary>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserLibrary> UserLibrary { get; set; }
    }
}
