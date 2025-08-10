using Microsoft.AspNetCore.Mvc.Rendering;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IPerusahaan
    {
        Task<string?> LoginAsync(LoginPerusahaanDTO loginPerusahaanDTO);
        Task<bool> PerusahaanExistsAsync(string name, string email);
        Task<bool> RegisterAsync(RegisterPerusahaanDTO model);
        public List<SelectListItem> Perusahaan();
    }
}
