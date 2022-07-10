using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._07.Task2.AssemblyOne
{
    class Motorcycle
    {
        // доступно в любом месте текущего проекта
        internal const ushort MaxSpeed = 300;
        // все равно, что private string vinNumber;
        string vinNumber = "2CD5689DF5-13GP-5698-AF45-95GHHV4IOP15";
        public int odometer = 20_000;
        // поле доступно только из текущего класса
        private string model = "BMW";
        // доступно из текущего класса и производных классов, которые определены в этом же проекте
        protected private string bikeNumber = "Ff8465-YY";
        // доступно из текущего класса и производных классов
        protected string bikeColor = "Black";
        // доступно в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal string equipment = "VIP";

        // по умолчанию имеет модификатор private
        void Print() => Console.WriteLine(vinNumber);

        // метод доступен только из текущего класса
        private void PrintPrivate() => Console.WriteLine(model);

        // доступен из текущего класса и производных классов, которые определены в этом же проекте
        protected private void PrintProtectedPrivate() => Console.WriteLine(bikeNumber);

        // доступен из текущего класса и производных классов
        protected void PrintProtected() => Console.WriteLine(bikeColor);

        // доступен в любом месте текущего проекта
        internal void PrintInternal() => Console.WriteLine(MaxSpeed);

        // доступен в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal void PrintProtectedInternal() => Console.WriteLine(equipment);

        // доступен в любом месте программы, а также для других программ и сборок
        public void PrintPublic() => Console.WriteLine(odometer);

    }
    public class PublicState
    {
        internal void PrintInternal() => Console.WriteLine("internal");
        protected internal void PrintProtectedInternal() => Console.WriteLine("protected internal");
        public void PrintPublic() => Console.WriteLine("public");

    }

    // класс доступен только в текущей сборке - по умолчанию internal
    class DefaultlState { }
    // класс доступен только в текущей сборке
    internal class InternalState { }
}
