namespace UserList
{
   static class UserAlreadyExists
    {
        private static bool exists = false;

        public static bool Exists
        {
            get => exists;
            set => exists = value;
        }
    }
}