using System.ComponentModel.DataAnnotations;

namespace Veritas.Web.Models
{
    public class ViewAccount
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        
    }
}
