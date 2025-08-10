﻿using Microsoft.AspNetCore.Mvc.Rendering;
using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;
using PROJECT_CAREERCIN.Models;
using PROJECT_CAREERCIN.Interfaces;

namespace PROJECT_CAREERCIN.Services
{
    public class KategoriPekerjaanService : IKategoriPekerjaan
    {
        private readonly ApplicationContext _context;

        public KategoriPekerjaanService(ApplicationContext context)
        {
            _context = context;
        }

        public List<KategoriPekerjaanDTO> GetListKategoriPekerjaan()
        {
            var data = _context.KategoriPekerjaans.Select(x => new KategoriPekerjaanDTO
            {
                Id = x.Id,
                NamaKategori = x.NamaKategori,
                Deskripsi = x.Deskripsi,

            }).ToList();

            return data;
        }

        public KategoriPekerjaan GetListKategoriPekerjaanById(int id)
        {
            var data = _context.KategoriPekerjaans.FirstOrDefault(x => x.Id == id);
            if (data == null)
            {
                return new KategoriPekerjaan();
            }

            return data;
        }

        public bool UpdateKategoriPekerjaan(KategoriPekerjaanDTO kategoriPekerjaanDTO)
        {
            var data = _context.KategoriPekerjaans.FirstOrDefault(x => x.Id == kategoriPekerjaanDTO.Id);
            if (data == null)
            {
                return false;
            }

            data.Id = kategoriPekerjaanDTO.Id;
            data.NamaKategori = kategoriPekerjaanDTO.NamaKategori;
            data.Deskripsi = kategoriPekerjaanDTO.Deskripsi;

            _context.KategoriPekerjaans.Update(data);
            _context.SaveChanges();
            return true;
        }

        public bool AddKategoriPekerjaaan(KategoriPekerjaanDTO kategoriPekerjaanDTO)
        {
            var data = new KategoriPekerjaan();

            data.Id = kategoriPekerjaanDTO.Id;
            data.NamaKategori = kategoriPekerjaanDTO.NamaKategori;
            data.Deskripsi = kategoriPekerjaanDTO.Deskripsi;

            _context.KategoriPekerjaans.Add(data);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteKategoriPekerjaan(int id)
        {
            var data = _context.KategoriPekerjaans.FirstOrDefault(x => x.Id == id);

            if (data == null)
            {
                return false;
            }

            _context.KategoriPekerjaans.Remove(data);
            _context.SaveChanges();
            return true;
        }

        public List<SelectListItem> KategoriPekerjaan()
        {
            var datas = _context.KategoriPekerjaans
                .Select(x => new SelectListItem
                {
                    Text = x.NamaKategori,
                    Value = x.Id.ToString()
                }).ToList();

            return datas;
        }

    }
}
