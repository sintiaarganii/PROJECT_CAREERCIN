using Microsoft.AspNetCore.Mvc.Rendering;
using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface ILowonganPekerjaan
    {
        public List<LowonganPekerjaanViewDTO> GetListLowonganPekerjaan();
        public LowonganPekerjaan GetLowonganPekerjaanById(int id);
        public bool AddLowonganPekerjaan(LowonganPekerjaanAddUpdateDTO request);
        public bool UpdateLowonganPekerjaan(LowonganPekerjaanAddUpdateDTO lowonganPekerjaanAddUpdateDTO);
        public bool DeleteLowonganPekerjaan(int id);
        public List<SelectListItem> LowonganPekerjaan();
    }
}
