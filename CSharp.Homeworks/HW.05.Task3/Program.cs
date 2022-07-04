int[] randArray = new int[5];
Random rand = new Random();

for (int i = 0; i < randArray.Length; i++)
{
    randArray[i] = rand.Next();
}
foreach (int i in randArray)
{
    Console.WriteLine($"Your array numbers: {i}");
}

Console.WriteLine("\n");
Array.Reverse(randArray);

foreach (int i in randArray)
{
    Console.WriteLine($"Your new array numbers order: {i}");
}
//Optional task
/*Int64[] randArray2 = new Int64[100];

System.Diagnostics.Stopwatch.StartNew().Start();

for (int i = 0; i < randArray2.Length; i++)
{
    randArray2[i] = rand.Next();
}
foreach (int i in randArray2)
{
    Console.WriteLine($"Your array numbers: {i}");
}

Console.WriteLine("\n");
/*Array.Reverse(randArray2);

foreach (int i in randArray2)
{
    Console.WriteLine($"Your new array numbers order: {i}");
}
for (int i = randArray2.Length; i > 0; i--)
{
    Console.WriteLine($"Your array numbers now: {i}");
}
System.Diagnostics.Stopwatch.StartNew().Stop();
Console.WriteLine(System.Diagnostics.Stopwatch.StartNew().Elapsed);
*/
