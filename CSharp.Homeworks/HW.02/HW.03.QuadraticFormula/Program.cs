double a, b, c;
Console.WriteLine("Please enter a");
a = double.Parse( Console.ReadLine());
int a1 = Convert.ToInt32(a);
Console.WriteLine("Please enter b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter c");
c = double.Parse(Console.ReadLine());

//Diskriminant
double D = b * b - (4 * a * c);
Console.WriteLine($"Diskriminant of the equation = {D}");
if (D >= 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"First root of the equation x1 = {x1}");
    Console.WriteLine($"Second root of the equation x2 = {x2}");
}
else
{
    Console.WriteLine($"Equation have no roots, cause diskriminant of the equation = {D}");
}