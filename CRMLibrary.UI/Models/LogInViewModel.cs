using System.ComponentModel.DataAnnotations;

namespace CRMLibrary.UI.Models
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Have to supply an e-mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Have to supply a password")]
        public string Password { get; set; }
    }
}
