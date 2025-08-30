﻿using PROJECT_CAREERCIN.Helpers;
using PROJECT_CAREERCIN.Interfaces;
using PROJECT_CAREERCIN.Models.DB;
using PROJECT_CAREERCIN.Models.DTO;
using PROJECT_CAREERCIN.Models;
using Microsoft.EntityFrameworkCore;

namespace PROJECT_CAREERCIN.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationContext _context;
        private readonly JwtHelper _jwtHelper;
        private readonly IEnkripsiPassword _enkripsiPassword;
        private readonly ILogger<UserService> _logger;

        public UserService(ApplicationContext context, JwtHelper jwtHelper, IEnkripsiPassword enkripsiPassword, ILogger<UserService> logger)
        {
            _context = context;
            _jwtHelper = jwtHelper;
            _enkripsiPassword = enkripsiPassword;
            _logger = logger;
        }

        public async Task<string?> LoginAsync(LoginUserDTO loginDTO)
        {
            try
            {
                var user = await _context.Users
                    .FirstOrDefaultAsync(u => u.Username == loginDTO.Username);

                if (user == null)
                    return null; // User tidak ditemukan

                // Verifikasi password
                if (!_enkripsiPassword.VerifyPassword(loginDTO.Password, user.PasswordHash))
                    return null; // Password salah

                var token = _jwtHelper.GenerateToken(user.Username, user.Email, user.Id, user.Role);
                return token;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LoginAsync Error] {ex}");
                throw new Exception("Terjadi kesalahan saat login", ex);
            }
        }

        public async Task<bool> RegisterAsync(RegisterUserDTO registerDTO)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                // Cek apakah user sudah ada
                if (await UserExistsAsync(registerDTO.Username, registerDTO.Email))
                    return false;

                // Hash password
                var passwordHash = _enkripsiPassword.HashPassword(registerDTO.Password);

                var user = new User
                {
                    Username = registerDTO.Username,
                    Email = registerDTO.Email,
                    PasswordHash = passwordHash,
                    ProfileImage = "",
                    CoverImage = "",
                    Posisi = registerDTO.Posisi,
                    Role = "User",
                    CreatedAt = DateTime.Now,
                    Status = GeneralStatus.GeneralStatusData.Active
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"[RegisterAsync Error] {ex}");
                throw new Exception("Terjadi kesalahan saat registrasi", ex);
            }
        }


        public async Task<bool> UserExistsAsync(string username, string email)
        {
            return await _context.Users
                .AnyAsync(u => u.Username == username || u.Email == email);
        }

        public async Task<UserUpdateDTO?> GetUserByIdAsync(int userId)
        {
            try
            {
                // Mengambil User entity dari database
                var userEntity = await _context.Users.FindAsync(userId);

                if (userEntity == null)
                    return null;

                // Konversi dari User entity ke UserModel (DTO)
                // PENTING: Tidak mengirim PasswordHash ke client!
                return new UserUpdateDTO
                {
                    Id = userEntity.Id,
                    Username = userEntity.Username,
                    Email = userEntity.Email,
                    Password = "",// Kosongkan untuk keamanan
                    CreatedAt = userEntity.CreatedAt
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[GetUserByIdAsync Error] {ex}");
                throw new Exception("Gagal mengambil data user", ex);
            }
        }


    }
}
