using FluentValidation;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Validation
{
    public class LowonganPekerjaanAddUpdateValidator : AbstractValidator<LowonganPekerjaanAddUpdateDTO>
    {
        public LowonganPekerjaanAddUpdateValidator()
        {
            RuleFor(x => x.Judul)
                .NotEmpty().WithMessage("Judul wajib diisi.")
                .MaximumLength(150).WithMessage("Judul maksimal 150 karakter.");

            RuleFor(x => x.Alamat)
                .NotEmpty().WithMessage("Alamat wajib diisi.")
                .MaximumLength(250).WithMessage("Alamat maksimal 250 karakter.");

            RuleFor(x => x.Deskripsi)
                .NotEmpty().WithMessage("Deskripsi wajib diisi.")
                .MinimumLength(20).WithMessage("Deskripsi minimal 20 karakter.");

            RuleFor(x => x.Posisi)
                .NotEmpty().WithMessage("Posisi wajib diisi.")
                .MaximumLength(100).WithMessage("Posisi maksimal 100 karakter.");

            RuleFor(x => x.TanggalDibuat)
                .NotEmpty().WithMessage("Tanggal dibuat wajib diisi.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Tanggal tidak boleh di masa depan.");

            RuleFor(x => x.status)
                .IsInEnum().WithMessage("Status lowongan tidak valid.");
        }
    }

}
