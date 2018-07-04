namespace UserList.Date.Mvp.Models
{
    internal class CheckingInputData
    {
        public bool CheckPasswordConfirmation(string password, string confirmedPassword)
        {
            bool successfulVerification = false;

            if (confirmedPassword == password && password.Length > 0)
            {
                successfulVerification = true;
            }

            return successfulVerification;
        }

        public bool PasswordValidation(string password)
        {
            bool successfulVerification = true;

            if (password.Length < 1)
            {
                successfulVerification = false;
            }

            return successfulVerification;
        }

        public bool UsernameValidation(string username)
        {
            bool successfulVerification = true;

            if (username.Length < 5)
            {
                successfulVerification = false;
            }

            return successfulVerification;
        }
    }
}