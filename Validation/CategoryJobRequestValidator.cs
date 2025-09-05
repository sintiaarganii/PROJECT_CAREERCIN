﻿using FluentValidation;
using PROJECT_CAREERCIN.Models.DTO;
using PROJECT_CAREERCIN.Models;

namespace PROJECT_CAREERCIN.Validation
{
    public class CategoryJobRequestValidator : AbstractValidator<KategoriPekerjaanDTO>
    {
        private readonly ApplicationContext _context;
        public CategoryJobRequestValidator(ApplicationContext context)
        {
            _context = context;

            RuleFor(x => x.NamaKategori)
                .NotEmpty().WithMessage("Nama kategori wajib diisi.")
                .MinimumLength(3).WithMessage("Nama kategori minimal 3 karakter.")
                .MaximumLength(100).WithMessage("Nama kategori maksimal 100 karakter.");

            RuleFor(x => x.Deskripsi)
                .NotEmpty().WithMessage("Deskripsi wajib diisi.")
                .MinimumLength(12).WithMessage("Deskripsi minimal 12 karakter.")
                .MaximumLength(200).WithMessage("Deskripsi maksimal 500 karakter.");
        }
    }
}
