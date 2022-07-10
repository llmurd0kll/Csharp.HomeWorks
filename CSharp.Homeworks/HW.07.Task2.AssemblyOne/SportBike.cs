using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task2.AssemblyOne
{
    class SportBike : Motorcycle
    {
        public void PrintState()
        {
            Motorcycle motorcycle = new Motorcycle();

            // обратиться к переменной vinNumber у нас не получится,
            // так как она имеет модификатор private и класс SportBike ее не видит
            //Console.WriteLine(motorcycle.vinNumber); //Ошибка, получить доступ нельзя

            // то же самое относится и к переменной model
            //Console.WriteLine(motorcycle.model); // Ошибка, получить доступ нельзя

            // обратиться к переменной bikeNumber не получится
            // Console.WriteLine(motorcycle.bikeNumber); // Ошибка, получить доступ нельзя

            // обратиться к переменной bikeColor тоже не получится
            //Console.WriteLine(motorcycle.bikeColor); // Ошибка, получить доступ нельзя

            // переменная MaxSpeed с модификатором internal доступна из любого места текущего проекта
            // Console.WriteLine(motorcycle.MaxSpeed);// ошибка потому что значение константа

            // переменная equipment доступна из любого места текущего проекта
            Console.WriteLine(motorcycle.equipment);

            // переменная odometer общедоступна
            Console.WriteLine(motorcycle.odometer);


            Motorcycle motorcycle1 = new Motorcycle();

           // motorcycle1.Print(); //Ошибка, получить доступ нельзя

           // motorcycle1.PrintPrivate(); // Ошибка, получить доступ нельзя

           // motorcycle1.PrintProtectedPrivate(); // Ошибка, получить доступ нельзя

           // motorcycle1.PrintProtected(); // Ошибка, получить доступ нельзя

            motorcycle1.PrintInternal();    // норм

            motorcycle1.PrintProtectedInternal();  // норм

            motorcycle1.PrintPublic();      // норм
        }
    }
}
