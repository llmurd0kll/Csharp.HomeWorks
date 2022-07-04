int row, space, numb;

Console.WriteLine("Enter your number between 1-100: ");
numb = int.Parse(Console.ReadLine());

Console.WriteLine("\n");

int rowValue = 1;
int temp = numb;
//making rows here
for (row = 0; row < numb; row++)
{
    //making spaces before new row
    for(space = 0; space < numb-temp; space++)
    {
        Console.Write(" ");
    }
    //displaying our numbers
    for(int j = temp; j > 0; j--)
    {
        if(rowValue >= 10)
        {
            rowValue = rowValue-10;
        }
        //making spaces between numbers
        //in this result we delete space in the end of line
        if (j == 1)
        {
            Console.Write(rowValue);
        }
        //this result means that after first number goes another one
        else
        {
            Console.Write(rowValue + " ");
        }    
    }
    //making spaces after row
    for (space = 0; space < numb - temp; space++)
    {
        Console.Write(" ");
    }
    temp--;
    rowValue++;
 
    Console.WriteLine("\n");
}