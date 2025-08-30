using static PROJECT_CAREERCIN.Models.StatusLamaran;

namespace PROJECT_CAREERCIN.Models.DTO
{
    public class HistoryLamaranDTO
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Posisi { get; set; }
        public string Deskripsi { get; set; }
        public DateTime TanggalDilamar { get; set; }
        public DataStatusLamaran Status { get; set; }
    }
}
