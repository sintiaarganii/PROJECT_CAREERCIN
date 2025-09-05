using FluentValidation;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Validation
{
    public class LamaranValidator : AbstractValidator<LamaranAddUpdateDTO>
    {
        public LamaranValidator()
        {
            // Nama
            RuleFor(x => x.Nama)
                .NotEmpty().WithMessage("Nama wajib diisi.")
                .MaximumLength(100).WithMessage("Nama maksimal 100 karakter.");

            // Email
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email wajib diisi.")
                .EmailAddress().WithMessage("Format email tidak valid.");

            // NoHP
            RuleFor(x => x.NoHP)
                .NotEmpty().WithMessage("Nomor HP wajib diisi.")
                .Matches(@"^[0-9]{10,15}$").WithMessage("Nomor HP harus berupa angka 10-15 digit.");

            // Pendidikan (enum)
            RuleFor(x => x.Pendidikan)
                .IsInEnum().WithMessage("Status pendidikan tidak valid.");

            // GajiSaatIni
            RuleFor(x => x.GajiSaatIni)
                .GreaterThanOrEqualTo(0).WithMessage("Gaji saat ini tidak boleh negatif.");

            // GajiDiharapkan
            RuleFor(x => x.GajiDiharapkan)
                .GreaterThan(0).WithMessage("Gaji yang diharapkan harus lebih dari 0.")
                .GreaterThan(x => x.GajiSaatIni).WithMessage("Gaji diharapkan harus lebih besar dari gaji saat ini.");

            // Status (enum)
            RuleFor(x => x.Status)
                .IsInEnum().WithMessage("Status lamaran tidak valid.");
        }
    }
}
