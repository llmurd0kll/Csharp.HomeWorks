int num1, num2;

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

int sum = num1 + num2;
Console.WriteLine($"The amount of {num1} and {num2} is: {sum}");