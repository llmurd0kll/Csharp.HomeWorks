using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class MusicFiles : Catalog
    {
        public string[] singer = {"Nickelback ", "Linkin Park ", "Papa Roach "};
        public double[] length = {2.56, 3.15, 2.48};       
        public void Play()
        {         
            Console.WriteLine($"Next song in queue is : {singer[new Random().Next(0, singer.Length)]}");
        }

        public void RetrieveInformation()
        {
            Console.WriteLine($"Song singer is {singer[0]}, it's length is {length[0]}");
            Console.WriteLine($"Song singer is {singer[1]}, it's length is {length[1]}");
            Console.WriteLine($"Song singer is {singer[2]}, it's length is {length[2]}");

            /*length.ToString();
            List<string> songInfo = new List<string>();
            songInfo.Add(singer[1] + length[1]);
            songInfo.Add(singer[2] + length[2]);
            catalogs.AddRange(songInfo);*/
        }
    }
}
