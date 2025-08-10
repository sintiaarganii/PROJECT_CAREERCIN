using Microsoft.AspNetCore.Mvc.Rendering;
using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IKategoriPekerjaan
    {
        public List<KategoriPekerjaanDTO> GetListKategoriPekerjaan();
        public KategoriPekerjaan GetListKategoriPekerjaanById(int id);
        public bool UpdateKategoriPekerjaan(KategoriPekerjaanDTO kategoriPekerjaanDTO);
        public bool AddKategoriPekerjaaan(KategoriPekerjaanDTO kategoriPekerjaanDTO);
        public bool DeleteKategoriPekerjaan(int id);
        public List<SelectListItem> KategoriPekerjaan();
    }
}
