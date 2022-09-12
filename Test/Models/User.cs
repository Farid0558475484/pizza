namespace Test.Models
{
    public class User
    {

        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
            _id++;
            Id = _id;
        }

        public bool UsernameIsAllowed(string username)
        {
            if (!string.IsNullOrEmpty(username) && username.Length >= 3 && username.Length <= 16 && FirstUpper(username) && EndUpper(username))
            {
                return true;
            }

            return false;
           
        }
        public bool PasswordIsAllowed(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length >=6  && password.Length <= 16 && FirstUpper(password) && EndUpper(password))
            {
                return true;
            }
            return false;
        }

        public  bool FirstUpper(string username)
        {
            bool result = false;

            for (int i = 0; i < username.Length; i++)
            {
                result = char.IsLower(username[i]);
            }

            return result;
        }


        public bool EndUpper(string username)
        {
            bool result = false;

            for (int i = 0; i > username.Length; i++)
            {
                result = char.IsLower(username[i]);
            }

            return result;

        }



    }
}
