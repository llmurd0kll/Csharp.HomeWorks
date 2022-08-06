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

        public override string ToString()
        {
            return $"Company: {Company}, Full Name: {FirstName} {LastName}, Experience: {Experience}, Title: , Salary:, GitHub: {GitHubAccount} "; 
        }
    }
}
