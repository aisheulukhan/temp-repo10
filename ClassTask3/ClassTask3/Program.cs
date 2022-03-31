using System;

namespace ClassTask3.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname = "";
            string password = "";
            string email = "";

            int key;
            do
            {
                Console.WriteLine("1.Show info");
                Console.WriteLine("2. Create new group");
                Console.WriteLine("Reqem daxil edin");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 2:
                        User user1;
                        UserFullName(ref fullname);
                        UserPassword(ref password);
                        Console.WriteLine(User.PasswordChecker( password));
                        UserEmail(ref email);
                        user1 = new User(email,password);
                        user1.ShowInfo();



                        break;
                    default:
                        break;
                }
            } while (true);
        }
        
        static void UserFullName(ref string fullname)
        {
            Console.WriteLine(" Adını daxil edin");
            fullname = Convert.ToString(Console.ReadLine());
        }
        static void UserPassword(ref string password)
        {
            Console.WriteLine("Sifre daxil edin");
            password = Convert.ToString(Console.ReadLine());
        }
        static void UserEmail(ref string email)
        {
            Console.WriteLine("Emaili daxil edin");
            email = Convert.ToString(Console.ReadLine());
        }


    }
}
