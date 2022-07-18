using HW._09.Task3;

Console.WriteLine("Enter your data for catalog:");
Catalog catalog = new Catalog();
Console.WriteLine("Enter catalog name: ");
catalog.name = Console.ReadLine();
Console.WriteLine("Enter catalog code: ");
catalog.code = Console.ReadLine();
Console.WriteLine("Enter catalog size: ");
catalog.size = int.Parse(Console.ReadLine());
Console.WriteLine("Enter catalog category: ");
catalog.category = Console.ReadLine();