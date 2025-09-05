using FluentValidation;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Validation
{
    public class RegisterPerusahaanValidator : AbstractValidator<RegisterPerusahaanDTO>
    {
        public RegisterPerusahaanValidator()
        {
            RuleFor(x => x.NamaPerusahaan)
                .NotEmpty().WithMessage("Nama perusahaan wajib diisi")
                .MinimumLength(3).WithMessage("Nama perusahaan minimal 3 karakter")
                .MaximumLength(100).WithMessage("Nama perusahaan maksimal 100 karakter");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email wajib diisi")
                .EmailAddress().WithMessage("Format email tidak valid");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password wajib diisi")
                .MinimumLength(6).WithMessage("Password minimal 6 karakter");

            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Role wajib diisi");

            RuleFor(x => x.Telepon)
                .NotEmpty().WithMessage("Nomor telepon wajib diisi")
                .Matches(@"^\d{10,15}$").WithMessage("Nomor telepon harus 10-15 digit");

            RuleFor(x => x.Alamat)
                .NotEmpty().WithMessage("Alamat wajib diisi");

            RuleFor(x => x.Kota)
                .NotEmpty().WithMessage("Kota wajib diisi");

            RuleFor(x => x.Provinsi)
                .NotEmpty().WithMessage("Provinsi wajib diisi");

            RuleFor(x => x.BidangUsaha)
                .NotEmpty().WithMessage("Bidang usaha wajib diisi");

            RuleFor(x => x.TanggalBerdiri)
                .NotEmpty().WithMessage("Tanggal berdiri wajib diisi")
                .LessThanOrEqualTo(DateTime.Today).WithMessage("Tanggal berdiri tidak boleh di masa depan");
        }
    }
}
