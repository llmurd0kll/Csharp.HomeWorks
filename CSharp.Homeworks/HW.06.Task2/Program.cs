string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
Console.WriteLine($"Text for work is: {text}");
string seperators = "(),.";
string s = @"\s{1,}";

void MinLengthWordFind (string text)
{
    var textOut = new string(text.Where(x => !seperators.Contains(x)).ToArray()).Split(' ').Select(v => v.Trim(' '));

    var minLenWrd = textOut.Where(z => z.Length == textOut.Min(c => c.Length)).First();
    Console.WriteLine($"The shortest word is: {minLenWrd} \n");

    var sentWithoutWord = textOut.Where(z => z.Length != textOut.Min(c => c.Length));
    Console.WriteLine(string.Join(" ", sentWithoutWord));
}

void LongWordDelete(string text)
{
    var textOut = new string(text.Where(x => !seperators.Contains(x)).ToArray()).Split(' ').Select(v => v.Trim(' '));

    var maxLenWrd = textOut.Where(z => z.Length == textOut.Max(c => c.Length)).First();
    Console.WriteLine($"The longest word is: {maxLenWrd} \n");

    var sentWithoutWord = textOut.Where(z => z.Length != textOut.Max(c => c.Length));
    Console.WriteLine(string.Join(" ", sentWithoutWord));
}
void Swapping(string[] value, int position1, int position2)
{
    string temp = value[position1];
    value[position1] = value[position2];
    value[position2] = temp;
}
void ReplacedWords(string text)
{
    string[] words = System.Text.RegularExpressions.Regex.Split(text, @"\s{1,}");
    int[] word = new int[words.Length];
    for (int i = 0; i < words.Length; i++)
        word[i] = words[i].Length;

    int minIndex = Array.IndexOf(word, word.Min());
    int maxIndex = Array.IndexOf(word, word.Max());
    Swapping(words, minIndex, maxIndex);
    string textWithReplacedWords = words[0];
    for (int i = 1; i < words.Length; i++)
        textWithReplacedWords = textWithReplacedWords + " " + words[i];
    Console.WriteLine(textWithReplacedWords);


}
void AmountOfSigns(string text)
{
    Console.WriteLine("Amount of signs is: " + text.Count(char.IsPunctuation));
}
void AmountOfLetters (string text)
{
    int amOfLet = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text.Substring(i, 1) != " " && text.Substring(i, 1) != "," && text.Substring(i, 1) != ".")
            amOfLet++;
    }
    Console.WriteLine("Amount of latters is: " + amOfLet);
}

void Task4 (string text)
{
    char[] separators = new char[] { ' ' };

    string[] splitText = text.Split(separators);

    Array.Sort(splitText, (x, y) => y.Length.CompareTo(x.Length));
    Console.WriteLine(string.Join(" ", splitText));
}
Console.WriteLine("It's is first task: ");
LongWordDelete(text);
Console.WriteLine("It's is second task: ");
ReplacedWords(text);
Console.WriteLine("It's is third task: ");
AmountOfSigns(text);
AmountOfLetters(text);
Console.WriteLine("It's is 4 task: ");
Task4(text);