using System;

namespace CRMLibrary.UI.Models
{
    public class UserViewModel
    {
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
    }
}
