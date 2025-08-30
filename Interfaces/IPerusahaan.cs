using Microsoft.AspNetCore.Mvc.Rendering;
using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IPerusahaan
    {
        public CompanyViewDTO GetCurrentCompany();
        public List<CompanyViewDTO> GetListCompany();
        public Perusahaan GetCompanyById(int id);
        public bool UpdateCompany(RegisterPerusahaanDTO dto);
        Task<string?> LoginAsync(LoginPerusahaanDTO loginPerusahaanDTO);
        Task<bool> PerusahaanExistsAsync(string name, string email);
        Task<bool> RegisterAsync(RegisterPerusahaanDTO model);
        public List<SelectListItem> Perusahaan();
    }
}
