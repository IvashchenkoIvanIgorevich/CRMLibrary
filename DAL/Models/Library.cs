using System.Collections.Generic;

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
