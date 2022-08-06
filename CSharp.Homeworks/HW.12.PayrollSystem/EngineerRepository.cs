using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._12.PayrollSystem
{
    public class EngineerRepository : IEngineerRepository
    {
        private List<Engineer> engineers = new List<Engineer>();

        public void CreateEngineer()
        {
            Console.WriteLine("Please enter your engineer");
            Engineer engineer = new Engineer();

            Console.WriteLine("New ID created");
            engineer.Id = Guid.NewGuid();

            Console.WriteLine("Please enter First Name");
            engineer.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter Last Name");
            engineer.LastName = Console.ReadLine();

            Console.WriteLine("Please enter birthday in format: dd.mm.yyyy");
            DateTime birthday = new DateTime();
            birthday.ToShortDateString();
            birthday = DateTime.Parse(Console.ReadLine());
            engineer.DayOfBirth = birthday;

            Console.WriteLine("Please enter Experience");
            engineer.Experience = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter GitHub Account URL");
            engineer.GitHubAccount = Console.ReadLine();

            Console.WriteLine("Please enter Company");
            engineer.Company = Console.ReadLine();

            engineers.Add(engineer);
        }

        public void DeleteEngineer()
        {
            Console.WriteLine("Enter the id of the item which you want to delete");
            int userAnswer = Int32.Parse(Console.ReadLine());

            foreach (var engineerPers in engineers)
            {
                if (engineerPers.Id.Equals(userAnswer))
                {
                    engineers.Remove(engineerPers);
                }
                else
                {
                    Console.WriteLine("There is no item with this ID");
                }
            }
        }

        public void UpdateEngineer()
        {
            Console.WriteLine("Enter the id of item which you want to update");
            int userAnswer = int.Parse(Console.ReadLine());

            foreach (var engineerPers in engineers)
            {
                if (engineerPers.Id.Equals(userAnswer))
                {
                    void ParametrSelection()
                    {
                        Console.WriteLine("Select what you whant to update: Id - 1, First Name - 2, Last Name - 3, Company - 4, Birthday - 5, GitHub account - 6, Experience - 7.");
                        var answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "1":
                                Console.WriteLine("Enter new Id for this item: ");
                                Guid newId = Guid.Parse(Console.ReadLine());
                                engineerPers.Id = newId;
                                ParametrSelection();
                                break;
                            case "2":
                                Console.WriteLine("Enter new FirstName for this item: ");
                                string newFirstName = Console.ReadLine();
                                engineerPers.FirstName = newFirstName;
                                ParametrSelection();
                                break;
                            case "3":
                                Console.WriteLine("Enter new LastName for this item: ");
                                string newLastName = Console.ReadLine();
                                engineerPers.LastName = newLastName;
                                ParametrSelection();
                                break;
                            case "4":
                                Console.WriteLine("Enter new Company for this item: ");
                                string newCompany = Console.ReadLine();
                                engineerPers.Company = newCompany;
                                ParametrSelection();
                                break;
                            case "5":
                                Console.WriteLine("Enter new date of birth for this item: ");
                                DateTime newDate = DateTime.Parse(Console.ReadLine());
                                engineerPers.DayOfBirth = newDate;
                                ParametrSelection();
                                break;
                            case "6":
                                Console.WriteLine("Enter new GitHub Account for this item: ");
                                string newAccount = Console.ReadLine();
                                engineerPers.GitHubAccount = newAccount;
                                ParametrSelection();
                                break;
                            case "7":
                                Console.WriteLine("Enter new Experience for this item: ");
                                int newExp = Int32.Parse(Console.ReadLine());
                                engineerPers.Experience = newExp;
                                ParametrSelection();
                                break;
                            default:
                                Console.WriteLine("Wrong selection");
                                break;

                        }
                        Console.WriteLine(engineerPers);
                    }
                }
                else
                {
                    Console.WriteLine("There is no item with this ID");
                }
            }
        }

        public void ViewAllEngineers()
        {
            foreach (var engineerPers in engineers)
            {
                engineerPers.ToString();
                Console.WriteLine($"These are all your engineers:\n {engineerPers.ToString()}");
            }
        }
    }
}
