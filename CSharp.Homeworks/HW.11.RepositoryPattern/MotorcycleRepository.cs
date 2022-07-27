using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._11.RepositoryPattern
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        private List<Motorcycle> motorcycles = new List<Motorcycle>();

        /// <summary>
        /// Method GetMotorcycleByID() can find any of yours motos by moto ID.
        /// </summary>
        public void GetMotorcycleByID()
        {

            try
            {
                Console.WriteLine("Enter the id of moto you whant to find: ");
                int userAnswer = Int32.Parse(Console.ReadLine());
                foreach (var motorcycleItem in motorcycles)
                {
                    if (motorcycleItem.Id == userAnswer)
                    {
                        Console.WriteLine(motorcycleItem);
                    }
                    else
                    {
                        Console.WriteLine("There is no item with this ID!!");
                        
                        throw new Exception("MotorcycleNotFoundException");                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex.Message}");
            }
            
        }

        /// <summary>
        /// Method GetMotorcycles() shows all motos we have.
        /// </summary>
        public void GetMotorcycles()
        {
            foreach (var motorcycleItem in motorcycles)
            {
                motorcycleItem.ToString();
                Console.WriteLine($"These are all your motos:\n {motorcycleItem.ToString()}");
            }
        }

        /// <summary>
        /// Method CreateMotorcycle() create a new moto.
        /// </summary>
        public void CreateMotorcycle()
        {
            Console.WriteLine("Please enter your motorcycle");
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine("Please enter ID");
            motorcycle.Id = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Name");
            motorcycle.Name = Console.ReadLine();

            Console.WriteLine("Please enter Model");
            motorcycle.Model = Console.ReadLine();

            Console.WriteLine("Please enter Year");
            motorcycle.Year = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Odometr");
            motorcycle.Odometr = Int32.Parse(Console.ReadLine());
           
            motorcycles.Add(motorcycle);
        }

        /// <summary>
        /// Method UpdateMotorcycle() updates information about selected moto.
        /// </summary>
        public void UpdateMotorcycle()
        {
            Console.WriteLine("Enter the id of item which you want to update");
            int userAnswer = Int32.Parse(Console.ReadLine());

            foreach (var motorcycleItem in motorcycles)
            {
                if (motorcycleItem.Id == userAnswer)
                {
                    void ParametrSelection()
                    {
                        Console.WriteLine("Select what you whant to update: ");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "Id":
                                Console.WriteLine("Enter new Id for this item: ");
                                int newId = Int32.Parse(Console.ReadLine());
                                motorcycleItem.Id = newId;
                                ParametrSelection();
                                break;
                            case "Name":
                                Console.WriteLine("Enter new Name for this item: ");
                                string newName = Console.ReadLine();
                                motorcycleItem.Name = newName;
                                ParametrSelection();
                                break;
                            case "Model":
                                Console.WriteLine("Enter new Model for this item: ");
                                string newModel = Console.ReadLine();
                                motorcycleItem.Model = newModel;
                                ParametrSelection();
                                break;
                            case "Year":
                                Console.WriteLine("Enter new Year for this item: ");
                                int newYear = Int32.Parse(Console.ReadLine());
                                motorcycleItem.Year = newYear;
                                ParametrSelection();
                                break;
                            case "Odometr":
                                Console.WriteLine("Enter new Odometr for this item: ");
                                int newOdometr = Int32.Parse(Console.ReadLine());
                                motorcycleItem.Odometr = newOdometr;
                                ParametrSelection();
                                break;
                            default:
                                Console.WriteLine("Wrong selection");
                                break;

                        }
                        Console.WriteLine(motorcycleItem);
                    }            
                }
                else
                {
                    Console.WriteLine("There is no item with this ID");
                }
            }
        }

        /// <summary>
        /// Method DeleteMotorcycle() delete selected moto.
        /// </summary>
        public void DeleteMotorcycle()
        {
            Console.WriteLine("Enter the id of the item which you want to delete");
            int userAnswer = Int32.Parse(Console.ReadLine());

            foreach (var motorcycleItem in motorcycles)
            {
                if (motorcycleItem.Id == userAnswer)
                {
                    motorcycles.Remove(motorcycleItem);
                }
                else
                {
                    Console.WriteLine("There is no item with this ID");
                }
            }               
        }
    }
}
