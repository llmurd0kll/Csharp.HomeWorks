using HW._13.Task2;
using System.Text.Json;

Song song = new Song();

Selection();

void Selection()
{
    Console.WriteLine("Please select your next action:\n To create song select: 1.\n " +
        "To see all your songs select: 2.\n " +
        "To exit select: 0");

    var answer = Console.ReadLine();

    switch (answer)
    {
        case "1":
            song.CreateSong();
            Selection();
            break;
        case "2":
            song.GetSongData();
            Selection();
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Wrong selection");
            break;
    }
}