Console.WriteLine("Enter the number. It should be >0 :");
int entNum = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 1; i <= entNum; ++i)
{
    result += i;
    
}
Console.WriteLine(result);