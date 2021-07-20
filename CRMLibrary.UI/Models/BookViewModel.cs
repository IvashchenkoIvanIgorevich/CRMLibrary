using System;

namespace CRMLibrary.UI.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishedYear { get; set; }
        public string Redaction { get; set; }
        public int Pages { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
    }
}
