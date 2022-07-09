Console.WriteLine("Enter your line: ");
string text = Console.ReadLine();

///<summary>
/// FindSum() method used to find amount.
///</summary>
///<param name="text">Text wich was entered by user</param>
void FindSum(string text)
{
   
    string temp = "0";
    int sum = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char ch = text[i];

        if (char.IsDigit(ch))
            temp += ch;

        else
        {
            sum += int.Parse(temp);
            temp = "0";
        }
    }

      int result = sum + int.Parse(temp);
    Console.WriteLine(result);
}

///<summary>
/// FindMin() method used to find difference.
///</summary>
///<param name="text">Text wich was entered by user</param>
void FindDif(string text)
{
     string temp = "0";
     int sum = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char ch = text[i];

        if (char.IsDigit(ch))
            temp += ch;

        else
        {
            sum += int.Parse(temp);
            temp = "0";
        }
    }

    int result = sum - int.Parse(temp);
    Console.WriteLine(result);
}

///<summary>
/// FindDel() method used to find division.
///</summary>
///<param name="text">Text wich was entered by user</param>
void FindDiv(string text)
{
    string temp = "0";
    int sum = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char ch = text[i];

        if (char.IsDigit(ch))
            temp += ch;

        else
        {
            sum += int.Parse(temp);
            temp = "0";
        }
    }

    int result = sum / int.Parse(temp);
    Console.WriteLine(result);
}

///<summary>
/// FindMult() method used to find multiplication.
///</summary>
///<param name="text">Text wich was entered by user</param>
void FindMult(string text)
{
    string temp = "0";
    int sum = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char ch = text[i];

        if (char.IsDigit(ch))
            temp += ch;

        else
        {
            sum += int.Parse(temp);
            temp = "0";
        }
    }
    int result = sum * int.Parse(temp);
    Console.WriteLine(result);
}

Console.WriteLine("Select operator between: -,+,/,*, witch you entered");
string choose = Console.ReadLine();

switch (choose)
{
    case "+":
        FindSum(text);
        break;
    case "-":
        FindDif(text);
        break;
    case "/":
        FindDiv(text);
        break;
    case "*":
        FindMult(text);
        break;
    default:
        Console.WriteLine("Wrong sign!");
        break;
}