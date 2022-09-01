using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._15.Task1
{
    static class ModifyExtension
    {
        public static string Modify(this string text) 
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (i.Equals(9))
                {
                    text = text.Remove(i);
                }
            }
            return text + "...";
        }

        public static string Converting(this string converting)
        {
            string output = converting switch
            {
                var i when i == "TRUE" => 1.ToString(),
                var i when i == "FALSE" => 0.ToString() ,
                _ => throw new ErrorWithConvertingException("Something went wrong. Converting is impossible")
            };

            return output;
        }
    }
}
