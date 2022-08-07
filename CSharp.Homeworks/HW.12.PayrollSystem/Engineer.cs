using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._12.PayrollSystem
{
    public class Engineer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int Experience { get; set; }
        public string Responsibilities { get; set; }
        public string Technologies { get; set; }
        public string GitHubAccount { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public int Sallary { get; set; }
       
        public void TitleSelection()
        {
            Console.WriteLine("Select your title:\n " +
                "1 - Junior Developer,\n " +
                "2 - Middle Developer,\n " +
                "3 - Senior Developer,\n " +
                "4 - Team Leader,\n " +
                "5 - Architect");
            string titleAnswer = Console.ReadLine();

            switch (titleAnswer)
            {
                case "1":
                    Title = "Junior Developer";
                        break;
                case "2":
                    Title = "Middle Developer";
                    break;
                case "3":
                    Title = "Senior Developer";
                    break;
                case "4":
                    Title = "Team Leader";
                    break;
                case "5":
                    Title = "Architect";
                    break;
                default:
                    Console.WriteLine("Wrong selection");
                    break;
            }
        }

        public void SallaryCount()
        {
            int baseSallary = 500;
            if (Title.Equals("Junior Developer"))
            {
                Sallary = baseSallary;
            }
            else if(Title.Equals("Middle Developer"))
            {
                Sallary = baseSallary * 3;
            }
            else if (Title.Equals("Senior Developer"))
            {
                Sallary = baseSallary * 5 + 300;
            }
            else if (Title.Equals("Team Leader"))
            {
                Sallary = baseSallary * 8 + 500;
            }
            else if (Title.Equals("Architect"))
            {
                Sallary = baseSallary * 12 + 1000;
            }
        }

        public void GetResponsibilities()
        {
            if (Title.Equals("Junior Developer"))
            {
                Responsibilities = "Data Bases, O/RM, ASP.NET MVC, WPF, Web Stack";

            }
            else if (Title.Equals("Middle Developer"))
            {
                Responsibilities = "Hard Skills, SASS/SCSS/Less/PostCSS, RESTful interfaces, SOLID, 3 pillars of OOP";
            }
            else if (Title.Equals("Senior Developer"))
            {
                Responsibilities = "Development and design of client-server software, Knowledg of OOP, OOD, Knowledge of the basic principles of computer networks and protocols(IP, TCP, UDP)," +
                    "Strong knowledge of design patterns, The ability to clearly and concisely express one's thoughts in written and oral form in English;";
            }
            else if (Title.Equals("Team Leader"))
            {
                Responsibilities = "Taking care of your team, Ensure the professional and career growth of your team, Setting goals and evaluating progress," +
                    " Conflict resolution, Organization of team events";
            }
            else if (Title.Equals("Architect"))
            {
                Responsibilities = "Clarification of project requirements and communication with the customer, Technological research and prototyping, Архитектура конечного продукта," +
                    " General context (helicopter view), Technical knowledge";
            }
        }

        public override string ToString()
        {
            return $"Company: {Company}, Full Name: {FirstName} {LastName}, \n" +
                $"Experience: {Experience}, \n" +
                $"Title: {Title} , \n" +
                $"Salary: {Sallary}, \n" +
                $"GitHub: {GitHubAccount}, \n" +
                $"Your responsibilities: {Responsibilities} \n";
        }
    }
}
