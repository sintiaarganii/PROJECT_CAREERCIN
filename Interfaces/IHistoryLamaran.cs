using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IHistoryLamaran
    {
        public List<HistoryLamaranDTO> GetListHistoryLowongan();
        public bool DeletelamaranTersimpan(int id);
    }
}
