using System.ComponentModel.DataAnnotations;

namespace HotelierAPI_WebUI.DTOs.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage = "Kullanıcı adı kısmı boş geçilemez..")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Şifre kısmı boş geçilemez..")]
        public string Password { get; set; }
    }
}
