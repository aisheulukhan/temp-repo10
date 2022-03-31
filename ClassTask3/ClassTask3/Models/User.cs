using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    class User :IAccount
    {
        private static int _id;
        private string _password;
        private string _fullName;
        private string _email;
        public string FullName { get; set; }
        public int Id
        {
            get;
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }

        }
        static User()
        {
            _id = 0;
        }
        public User()
        {
            _id++;
            Id = _id;
        }
        public User(string email, string password) :this()
        {
            Email = email;
            Password = password;
            
        }
        public User(string email, string password, ref string fullName) : this(email, password)
        {
            this.FullName = fullName;
        }

        public void ShowInfo()
        {
            Console.WriteLine($" Id - {Id}");
            Console.WriteLine($"Full Name - {FullName}");
            Console.WriteLine($"Email - {Email}");
            Console.WriteLine($"Password - {Password}");
        }
        public static bool PasswordChecker(string password)
        {
            bool isupper = false;
            bool islower = false;
            bool isdigit = false;
            if (password.Length >= 8)
            {
                foreach (var item in password)
                {
                    if (char.IsUpper(item)) isupper = true;
                    else if (char.IsLower(item)) islower = true;
                    else if (char.IsDigit(item)) isdigit = true;
                }
                if (isdigit && islower && isupper) return true;
                
            }
            return false;

        }
    }
}
