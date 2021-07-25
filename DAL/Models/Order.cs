using System;

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
