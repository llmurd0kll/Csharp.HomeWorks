int[] array1 = new int[10];

for (int i = 0; i < array1.Length-1; i++)
{
    Console.WriteLine("Enter your numbers");
    array1[i] = int.Parse(Console.ReadLine());
}

foreach (int i in array1)
{
    Console.WriteLine($"Your array numbers: {i}\n");
}

Console.WriteLine("Enter your position for value");
int pos = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your number for array");
int newPosForValue = int.Parse(Console.ReadLine());

int newPos;

for (int i = pos; i < array1.Length-1; i++)
{
    newPos = array1[i];
    array1[i] = newPosForValue;
    newPosForValue = newPos;
}

foreach(int i in array1)
{
    Console.WriteLine($"Your array numbers now: {i}");
}
