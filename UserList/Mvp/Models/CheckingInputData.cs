namespace UserList.Mvp.Models
{
    internal class CheckingInputData
    {
        public bool CheckPasswordConfirmation(string password, string confirmedPassword)
        {
            bool successfulVerification = false;

            successfulVerification = confirmedPassword == password && password.Length > 0;

            return successfulVerification;
        }

        public bool PasswordValidation(string password)
        {
            bool successfulVerification = true;

            successfulVerification = password.Length >= 1;

            return successfulVerification;
        }

        public bool UsernameValidation(string username)
        {
            bool successfulVerification = true;

            successfulVerification = username.Length >= 5;

            return successfulVerification;
        }
    }
}