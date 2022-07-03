int[] randNum = new int[5];
int[] enteredNum = new int[5];
int[] sumOfPrev = new int[5];
Random rand = new Random();

for (int i = 0; i < randNum.Length; i++)
{
    randNum[i] = rand.Next();
}

for (int i = 0; i < enteredNum.Length; i++)
{
    Console.WriteLine("Enter your numbers");
    enteredNum[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < sumOfPrev.Length; i++)
{
    sumOfPrev[0] = randNum[0] + enteredNum[0];
    sumOfPrev[1] = randNum[1] + enteredNum[1];
    sumOfPrev[2] = randNum[2] + enteredNum[2];
    sumOfPrev[3] = randNum[3] + enteredNum[3];
    sumOfPrev[4] = randNum[4] + enteredNum[4];
}

foreach (int i in enteredNum)
{
    Console.WriteLine($"Elements of entered array: {i}\n");
}

foreach(int i in randNum)
{
    Console.WriteLine($"Elements of random array: {i}\n");
}

foreach(int i in sumOfPrev)
{
    Console.WriteLine($"Elements of sum array: {i}");
}