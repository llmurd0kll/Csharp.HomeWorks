using PatternSingleton;

var singleton = Singleton.GetInstance("Привет, мир!");
var singleton2 = Singleton.GetInstance("Здравствуй, космос!");
Console.WriteLine(singleton2.Data);
Console.ReadLine();

/*
Как мы видим, при попытке создания нескольких экземпляров класса, 
мы получаем один единственный уникальный экземпляр класса, с единой точкой входа и реализующий механизм поздней инициализации. 
Таким образом, мы полностью добились желаемого результата. */
