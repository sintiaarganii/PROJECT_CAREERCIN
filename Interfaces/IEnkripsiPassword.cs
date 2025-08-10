namespace PROJECT_CAREERCIN.Interfaces
{
    public interface IEnkripsiPassword
    {
        public string HashPassword(string password);
        public bool VerifyPassword(string password, string hashedPassword);
    }
}
