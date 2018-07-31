using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserList
{
    internal static class PictureKeys
    {
        private static string authenticationUsernamePicture = "Incorrect";
        private static string authenticationPasswordPicture = "Incorrect";
        private static string registrationUsernamePicture = "Incorrect";
        private static string registrationPasswordPicture = "Incorrect";
        private static string pictureСonfirmedPassword = "Incorrect";

        public static string AuthenticationUsernamePicture
        {
            get => authenticationUsernamePicture;
            set => authenticationUsernamePicture = value;
        }

        public static string AuthenticationPasswordPicture
        {
            get => authenticationPasswordPicture;
            set => authenticationPasswordPicture = value;
        }

        public static string RegistrationUsernamePicture
        {
            get => registrationUsernamePicture;
            set => registrationUsernamePicture = value;
        }

        public static string RegistrationPasswordPicture
        {
            get => registrationPasswordPicture;
            set => registrationPasswordPicture = value;
        }

        public static string PictureConfirmedPassword
        {
            get => pictureСonfirmedPassword;
            set => pictureСonfirmedPassword = value;
        }


    }
}