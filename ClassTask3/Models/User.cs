﻿using System;
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
        public string Email { get; set; }

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
        
        static User()
        {
            _id = 0;
        }
        public User()
        {
            _id++;
            Id = _id;
        }
        public User(string fullname, string email, string password) : this()
        {
            FullName = fullname;
            Email = email;
            Password = password;
        }



        public bool PasswordChecker(string password)
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
        public void ShowInfo()
        {
            Console.WriteLine($" Id - {Id}");
            Console.WriteLine($"Full Name - {FullName}");
            Console.WriteLine($"Email - {Email}");
            Console.WriteLine($"Password - {Password}");
        }
    }
}
