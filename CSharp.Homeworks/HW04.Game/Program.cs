Console.WriteLine("Enter the letter (W,S,A,D) to select where you would like to move");
string answer = Console.ReadLine();
Console.WriteLine($"Your answer is: {answer}");
switch (answer)
{
    case "w":
    case "W":
        Console.WriteLine("Moving up!");
        break;
    case "s":
    case "S":
        Console.WriteLine("Moving down!");
        break;
    case "d":
    case "D":
        Console.WriteLine("Moving right!");
        break;
    case "a":
    case "A":
        Console.WriteLine("Moving left!");
        break;
    default:
        Console.WriteLine("No movement needed");
        break ;
}