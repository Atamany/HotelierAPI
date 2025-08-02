using FluentValidation;
using HotelierAPI_WebUI.DTOs.GuestDTO;

namespace HotelierAPI_WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDTO>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Lütfen bir ad giriniz.")
                .MinimumLength(2).WithMessage("Ad, en az 2 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Ad, 50 karakterden uzun olamaz.");
            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Lütfen bir soyad giriniz.")
                .MinimumLength(2).WithMessage("Soyad, en az 2 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Soyad, 50 karakterden uzun olamaz.");
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Lütfen bir şehir giriniz.")
                .MinimumLength(3).WithMessage("Şehir, en az 3 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Şehir, 50 karakterden uzun olamaz.");
            RuleFor(x => x.TCKN)
                .NotEmpty().WithMessage("Lütfen bir TCKN giriniz.")
                .Length(11).WithMessage("TCKN, 11 karakter olmalıdır.")
                .Matches(@"^\d+$").WithMessage("TCKN sadece rakamlardan oluşmalıdır.");
            RuleFor(x => x.Telefon)
                .Length(13).WithMessage("Telefon numarası 13 rakamdan oluşmalıdır. (+901234567890)");
            RuleFor(x => x.Mail)
                .EmailAddress().WithMessage("Lütfen geçerli bir e-posta adresi giriniz.");
        }
    }
}
