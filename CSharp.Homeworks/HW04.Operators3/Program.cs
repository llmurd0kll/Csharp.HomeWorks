int num1, num2;
string answer = "Yes";

void EnterData()
{
    Console.WriteLine("Please, enter number 1: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Please, enter number 2: ");
    num2 = int.Parse(Console.ReadLine());
}

try
{
    EnterData();
}
catch (System.FormatException ex)
{
    Console.WriteLine($"There is an exception {ex}, please enter correct data: ");
    EnterData();
}

Console.WriteLine("Whant to see a result?");
answer = Console.ReadLine();

switch (answer)
{
    case "y":
    case "Y":
    case "Yes":
        int sum = num1 + num2;
        Console.WriteLine($"The amount of {num1} and {num2} is: {sum}");
        Console.WriteLine("what is your expected result?");
        int result = int.Parse(Console.ReadLine());
        if (result == sum)
        {
            Console.WriteLine($"It's correct, the amount is {sum}");
        }
        else
        if (result > sum)
        {
            Console.WriteLine($"It's wrong! Your amount is {sum}.The sum should be less");
        }
        else
        if (result < sum)
        {
            Console.WriteLine($"It's wrong! Your amount is {sum}.The sum should be bigger");
        }
        break;
    case "n":
    case "N":
    case "No":
        Console.WriteLine($"Your numbers are {num1} and {num2}. Thanks for usage.");
        break;
    default:
        Console.WriteLine("It's wrong answer, must be Yes or Y/y for a result, N/n or No only to see your numbers");
        break;
}
