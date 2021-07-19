namespace DAL.Models
{
    public partial class Formular
    {
        public int Id { get; set; }
        public int? IdUser { get; set; }

        public virtual User IdUserNavigation { get; set; }
    }
}
