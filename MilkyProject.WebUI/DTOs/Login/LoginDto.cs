using System.ComponentModel.DataAnnotations;

namespace MilkyProject.WebUI.DTOs.Login
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrenizi giriniz!")]
        public  string Password { get; set; }   
    }
}
