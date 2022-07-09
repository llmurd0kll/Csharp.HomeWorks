Console.WriteLine("Enter your poem in one row. Use ';' to divide rows");
string poem = Console.ReadLine();
char[] separators = new char[] {';'};

string[] splitPoem = poem.Split(separators, StringSplitOptions.RemoveEmptyEntries);

foreach (string splitedPoem in splitPoem)
{
    string replacedLetters = splitedPoem;
    replacedLetters = replacedLetters.Replace("a", "o");   
    Console.WriteLine($"New poem: {replacedLetters}");
}
