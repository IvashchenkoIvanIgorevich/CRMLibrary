using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class UserLibrary
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }
        public int? IdLibrary { get; set; }

        public virtual Library IdLibraryNavigation { get; set; }
        public virtual UserTypes IdUserNavigation { get; set; }
    }
}
