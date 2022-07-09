using System.Text.RegularExpressions;

Console.WriteLine("Enter your line: ");
string text = Console.ReadLine();

string temp = "0";
string temp1= "0";
int sum = 0;
int umn = 1;
int del = 1;


/*for (int i = 0; i < text.Length; i++)
{
    char ch = text[i];

    if (char.IsDigit(ch))
    {
        temp += ch;
    }
    else
    {
        if (text[i] == '-')
        {
            if (char.IsDigit(ch))
            {
                temp1 += ch;
            }
            else
            {
                int sign = int.Parse(temp) - int.Parse(temp1);
            }
        }
        if (text[i] == '*')
        {
            if (char.IsDigit(ch))
            {
                temp1 += ch;
            }
            else
            {
                umn = int.Parse(temp) * umn;
                //int umnres = umn * int.Parse(temp);
            }
        }
        if (text[i] == '/')
        {
            if (char.IsDigit(ch))
            {
                temp1 += ch;
            }
            else
            {
                int sign = int.Parse(temp) / int.Parse(temp1);
            }
        }
        if (text[i] == '+')
        {
            if (char.IsDigit(ch))
            {
                temp1 += ch;
            }
            else
            {
                int sign = int.Parse(temp) + int.Parse(temp1);
                // sum += int.Parse(temp);
                 //temp = "0";
                 //int result = sum + int.Parse(temp);
                 //Console.WriteLine(result);
            }
        }

        // increment sum by number found earlier
        // (if any)
        //sum += int.Parse(temp);

        // reset temporary string to empty
        temp = "0";
    }
}

// atoi(temp.c_str()) takes care of trailing
// numbers
int result = sum + int.Parse(temp);


Console.WriteLine(result);
*/

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
void FindMin(string text)
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
void FindDel(string text)
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
        FindMin(text);
        break;
    case "/":
        FindDel(text);
        break;
    case "*":
        FindMult(text);
        break;
    default:
        Console.WriteLine("Wrong sign!");
        break;
}