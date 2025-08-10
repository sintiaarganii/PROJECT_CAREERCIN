using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface ILowonganTersimpan
    {
        public List<LowonganTersimpanViewDTO> GetListLowonganTersimpan();
        public LowonganTersimpan GetLowonganTersimpanById(int id);
        Task<bool> AddLowonganTersimpan(LowonganTersimpanAddUpdateDTO dto, int lowonganId);
        public bool DeleteLowonganTersimpan(int id);
    }
}
