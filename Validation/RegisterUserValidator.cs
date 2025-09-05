using FluentValidation;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Validation
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserDTO>
    {
        public RegisterUserValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Nama username wajib diisi")
                .MinimumLength(3).WithMessage("Nama minimal 3 karakter")
                .MaximumLength(50).WithMessage("Nama maksimal 50 karakter");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email wajib diisi")
                .EmailAddress().WithMessage("Format email tidak valid");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password wajib diisi")
                .MinimumLength(6).WithMessage("Password minimal 6 karakter");

            RuleFor(x => x.Posisi)
                .NotEmpty().WithMessage("Posisi wajib diisi");
        }
    }
}
