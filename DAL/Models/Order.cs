using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime TakeDay { get; set; }
        public DateTime? BackDay { get; set; }
        public int? IdBook { get; set; }
        public int? IdUser { get; set; }

        public virtual Book IdBookNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
    }
}
