using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask3.Models
{
    interface IAccount
    {
       static bool PasswordChecker(string password)
        {
            return false;
        }
        
        void ShowInfo();

    }
}
