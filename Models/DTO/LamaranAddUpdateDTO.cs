using static PROJECT_CAREERCIN.Models.StatusPendidikan;
using static PROJECT_CAREERCIN.Models.StatusLamaran;

namespace PROJECT_CAREERCIN.Models.DTO
{
    public class LamaranAddUpdateDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LowonganId { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public int NoHP { get; set; }
        public DataStatusPendidikan Pendidikan { get; set; }
        public int GajiSaatIni { get; set; }
        public int GajiDiharapkan { get; set; }
        public IFormFile CV { get; set; }
        public DataStatusLamaran Status { get; set; }
    }
}
