using System;

namespace ClassTask3.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("AAAAA", 70);
            Student student2 = new Student("BBBBB", 90);
            Student student3 = new Student("CCCCCCC", 50);
            User user = new User();
            Group group = new Group();
            Console.WriteLine("User yaradin");
            Console.WriteLine("User name daxil edin");
            user.FullName = Console.ReadLine();
            Console.WriteLine("Email daxil edin");
            user.Email = Console.ReadLine();
            do
            {
                Console.WriteLine("Password daxil edin");
                user.Password = Console.ReadLine();
                if (!user.PasswordChecker(user.Password)) 
                {
                    Console.WriteLine("Sifre sehvdir");
                }
            } while (!user.PasswordChecker(user.Password));
            int key;
            do
            {
                Console.WriteLine("0. Quit");
                Console.WriteLine("1. Show Info");
                Console.WriteLine("2. Create new group");
                Console.WriteLine("Reqem daxil edin");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("Qrup yaradin");
                        do
                        {
                            Console.WriteLine("Qrupun nomresini daxil edin");
                            group.GroupNo = Console.ReadLine();
                            if (!group.CheckGroupNo(group.GroupNo))
                            {
                                Console.WriteLine("Qrupun nomresi sehvdir");
                            }
                        } while (!group.CheckGroupNo(group.GroupNo));
                        do
                        {
                            Console.WriteLine("Telebe sayini daxil edin");
                            group.StudentLimit = Convert.ToInt32(Console.ReadLine());
                            if (group.StudentLimit < 5 || group.StudentLimit > 18)
                            {
                                Console.WriteLine("Telebe sayi minimum 5, maximum 18 ola biler");
                            }
                        } while (!group.CheckGroupNo(group.GroupNo));
                        int choice;
                        do
                        {
                            Console.WriteLine("0. Quit");
                            Console.WriteLine("1. Show all Student");
                            Console.WriteLine("2. Get student by id");
                            Console.WriteLine("3. Add student");
                            Console.WriteLine("Reqem daxil edin");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 0:
                                    Console.WriteLine("Proqram sonlandi");
                                    break;
                                case 1:
                                    group.GetAllStudents();
                                    break;
                                case 2:
                                    Console.WriteLine("Id daxil edin");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    group.GetStudent(id);
                                    break;
                                case 3:
                                    group.AddStudent(student1);
                                    Console.WriteLine("Telebe elave olundu");
                                    break;
                                    
                                default:
                                    break;
                            }

                        } while (choice!=0);
                        break;
                    default:
                        Console.WriteLine("Duzgun daxil edin");
                        break;
                }
            } while (key != default);


        }
    }
}
