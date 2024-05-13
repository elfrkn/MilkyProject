using System.ComponentModel.DataAnnotations;

namespace MilkyProject.WebUI.DTOs.Login
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Mail Adresinizi giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz!")]
        public  string Password { get; set; }
       
    }
}
