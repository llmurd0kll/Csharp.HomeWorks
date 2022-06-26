Console.WriteLine("Please, enter the year of birth: ");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Please, enter the month of birth: ");
int month = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the current year: ");
int yearToday = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the current month by it's number: ");
int monthToday = int.Parse(Console.ReadLine());
Console.WriteLine($"Today is {yearToday}, {monthToday}");
int monthOld = monthToday - month;
if (monthOld <= 0)
{
    int yearOld = yearToday - (year + 1);
    Console.WriteLine($"It's age: {yearOld}");
}
else
{
    int yearOld = yearToday - year;
    Console.WriteLine($"It's age: {yearOld}");
}