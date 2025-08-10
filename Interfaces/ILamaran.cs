using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface ILamaran
    {
        public List<LamaranViewDTO> GetListLamaran();
        public Lamaran GetLamaranById(int id);
        Task<bool> AddLamaran(LamaranAddUpdateDTO lamaranAddUpdateDTO, int lowonganId);
        bool UpdateLamaran(LamaranAddUpdateDTO lamaranAddUpdateDTO);
        Task<byte[]> DownloadCvAsync(int lamaranId);
        public bool DeleteLamaran(int id);
    }
}
