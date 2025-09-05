using Microsoft.AspNetCore.Mvc.Rendering;
using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;
using X.PagedList;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IKategoriPekerjaan
    {
        public IPagedList<KategoriPekerjaanDTO> GetListKategoriPekerjaan(int page, int pageSize, string searchTerm = "");
        public bool UpdateKategoriPekerjaan(KategoriPekerjaanDTO kategoriPekerjaanDTO);
        public bool AddKategoriPekerjaaan(KategoriPekerjaanDTO kategoriPekerjaanDTO);
        public bool DeleteKategoriPekerjaan(int id);
        public List<SelectListItem> KategoriPekerjaan();
        public KategoriPekerjaanDTO GetListKategoriPekerjaanById(int id);
    }
}
