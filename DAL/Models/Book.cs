using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class Book
    {
        public Book()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishedYear { get; set; }
        public string Redaction { get; set; }
        public int Pages { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
