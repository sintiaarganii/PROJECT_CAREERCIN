using PROJECT_CAREERCIN.Interfaces;

namespace PROJECT_CAREERCIN.Helpers
{
    public class EnkripsiPasswordHelper : IEnkripsiPassword
    {
        // Instance methods untuk DI
        public string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password tidak boleh kosong", nameof(password));

            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashedPassword))
                return false;

            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch
            {
                return false;
            }
        }

        // Static methods tetap ada untuk backward compatibility
        public static string HashPasswordStatic(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPasswordStatic(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }
}
