using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    internal class Account
    {
        public string Login { get; set; }
        private string Password { get; set; }
        protected internal string Password2 { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public void Register()
        {
            Console.WriteLine("Please enter your login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            Password = Console.ReadLine();
            Console.WriteLine("Please enter your password 2-d time: ");
            Password2 = Console.ReadLine();
            if (Password != Password2)
            {
                Console.WriteLine("Chek your spelling and try again");
                Password2 = null;
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter your email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Please enter your phone number: ");
            PhoneNumber = Console.ReadLine();
        }

        public void LogIn ()
        {
            Console.WriteLine("Please enter your login");
            Login = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            Password = Console.ReadLine();
            Console.WriteLine("Please enter your password 2-d time: ");
            Password2 = Console.ReadLine();
            if (Password != Password2)
            {
                Console.WriteLine("Chek your spelling and try again");
                Password2 = null;
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
        }
    }
}
