using System;
using System.ComponentModel.DataAnnotations;

namespace CRMLibrary.UI.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Incorrect data")]
        public DateTime PublishedYear { get; set; }

        public string Redaction { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Allowed only integer")]
        public int Pages { get; set; }

        public string Summary { get; set; }

        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Filed Author allowed only characters")]
        public string Author { get; set; }

        public string Location { get; set; }

        public bool IsAvailable { get; set; }
    }
}
