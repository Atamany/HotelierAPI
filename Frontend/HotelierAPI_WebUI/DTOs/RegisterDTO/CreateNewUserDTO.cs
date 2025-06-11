using System.ComponentModel.DataAnnotations;

namespace HotelierAPI_WebUI.DTOs.RegisterDTO
{
    public class CreateNewUserDTO
    {
        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı alanı gereklidir.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "E-Posta alanı gereklidir.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre (Tekrar) alanı gereklidir.")]
        [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}
