using System.ComponentModel.DataAnnotations;

namespace LT.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public int Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
