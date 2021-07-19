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
