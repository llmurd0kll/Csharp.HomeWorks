using HW._09.Task3;
Console.WriteLine("Enter your data for catalog:");
Catalog catalog1 = new Catalog();
Console.WriteLine("Enter catalog name: ");
catalog1.name = Console.ReadLine();
Console.WriteLine("Enter catalog code: ");
catalog1.code = Console.ReadLine();
Console.WriteLine("Enter catalog size: ");
catalog1.size = int.Parse(Console.ReadLine());
Console.WriteLine("Enter catalog category: ");
catalog1.category = Console.ReadLine();

Films films = new Films();
MusicFiles mf = new MusicFiles();

films.RetrieveInformation();
mf.RetrieveInformation();

films.Play();
mf.Play();
