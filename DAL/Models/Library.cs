using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class Library
    {
        public Library()
        {
            User = new HashSet<User>();
            UserLibrary = new HashSet<UserLibrary>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? IdFilial { get; set; }

        public virtual Filial IdFilialNavigation { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserLibrary> UserLibrary { get; set; }
    }
}
