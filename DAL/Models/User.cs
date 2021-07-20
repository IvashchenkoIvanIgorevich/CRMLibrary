using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class User
    {
        public User()
        {
            Formular = new HashSet<Formular>();
            InverseIdDirectorNavigation = new HashSet<User>();
            Order = new HashSet<Order>();
        }        

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Inn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? IdUserTypes { get; set; }
        public int? IdLibrary { get; set; }
        public int? IdDirector { get; set; }

        public virtual User IdDirectorNavigation { get; set; }
        public virtual Library IdLibraryNavigation { get; set; }
        public virtual UserTypes IdUserTypesNavigation { get; set; }
        public virtual ICollection<Formular> Formular { get; set; }
        public virtual ICollection<User> InverseIdDirectorNavigation { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
