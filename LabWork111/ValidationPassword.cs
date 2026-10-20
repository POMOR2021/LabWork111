namespace LabWork111
{
    public static class ValidationPassword
    {
        public static bool ValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;
            if (password.Length >= 8 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
                return true;
            return false;
        }
    }
}
