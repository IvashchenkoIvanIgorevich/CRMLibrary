using System.Collections.Generic;

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
