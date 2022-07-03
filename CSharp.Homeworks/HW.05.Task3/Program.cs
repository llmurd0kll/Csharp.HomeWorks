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