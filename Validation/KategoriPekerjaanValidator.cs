using FluentValidation;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Validation
{
    public class KategoriPekerjaanValidator : AbstractValidator<KategoriPekerjaanDTO>
    {
        public KategoriPekerjaanValidator()
        {
            RuleFor(x => x.NamaKategori)
                .NotEmpty().WithMessage("Nama kategori wajib diisi.")
                .MaximumLength(100).WithMessage("Nama kategori maksimal 100 karakter.");

            RuleFor(x => x.Deskripsi)
                .NotEmpty().WithMessage("Deskripsi wajib diisi.")
                .MinimumLength(10).WithMessage("Deskripsi minimal 10 karakter.");
        }
    }
}
