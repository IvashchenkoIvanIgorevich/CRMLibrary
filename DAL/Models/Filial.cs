using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Filial
    {
        public Filial()
        {
            Library = new HashSet<Library>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Library> Library { get; set; }
    }
}
