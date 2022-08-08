using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class Films : Catalog
    {
        public string[] director = {"Director1 ", "Director2 ", "Director3 "};
        public string[] mainActor = {"Actor1 ", "Actor2 ", "Actor3 "};
        public string[] mainActress = { "Actress1", "Actress2", "Actress3" };

        public void Play()
        {
            Console.WriteLine($"Now I'll play a film of this director: {director[new Random().Next(0, director.Length)]}");
        }

        public void RetrieveInformation()
        {
            Console.WriteLine($"Film director is {director[0]}, main actor is {mainActor[0]}, main actress is {mainActress[0]}");
            Console.WriteLine($"Film director is {director[1]}, main actor is {director[1]}, main actress is {director[1]}");
            Console.WriteLine($"Film director is {director[2]}, main actor is {director[2]}, main actress is {director[02]}");
           
            /*List<string> filmInfo = new List<string>();
            filmInfo.Add(director[0] + mainActor[0] + mainActress[0]);
            filmInfo.Add(director[1] + mainActor[1] + mainActress[1]);
            filmInfo.Add(director[2] + mainActor[2] + mainActress[2]);
            catalogs.AddRange(filmInfo);*/
        }
    }
}
