using PROJECT_CAREERCIN.Models.DTO;

namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IUser
    {
        Task<string?> LoginAsync(LoginUserDTO loginDTO);
        Task<bool> RegisterAsync(RegisterUserDTO registerDTO);
        Task<bool> UserExistsAsync(string username, string email);
        Task<UserUpdateDTO?> GetUserByIdAsync(int userId);
    }
}
