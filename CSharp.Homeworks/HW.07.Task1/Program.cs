using System.Text;

StringBuilder sbtext = new StringBuilder("1a!2.3!!..4.!.? 6 7!.. ?");
string text = sbtext.ToString();
char[] separators = new char[] { '?' };

string[] splitText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
string sabText1 = splitText[0];
StringBuilder sbSabText1 = new StringBuilder(sabText1);
sbSabText1.Replace(".", "");
sbSabText1.Replace("!", "");
Console.WriteLine(sbSabText1);

string sabText2 = splitText[1];
StringBuilder sbSabText2 = new StringBuilder(sabText2);
sbSabText2.Replace("?", "_");
Console.WriteLine(sbSabText2);