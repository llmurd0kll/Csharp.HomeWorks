using HW._11.RepositoryPattern;
using Serilog;

Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.File("logs/HW.11..txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();

var time = DateTime.UtcNow;

try
{
    Log.Information($"Programm started at: {Convert.ToString(time)}");

    MotorcycleRepository motorcycle = new MotorcycleRepository();

    Selection();

    void Selection()
    {
        Console.WriteLine("Please select your next action:\n To create motorcycle select: 1.\n " +
            "To see all your motorcycles select: 2.\n " +
            "To find your motorcycle with it's ID select: 3.\n " +
            "To update your moto select: 4.\n " +
            "To delete your moto select: 5.\n " +
            "To exit select: 0");

        var answer = Console.ReadLine();

        switch (answer)
        {
            case "1":
                motorcycle.CreateMotorcycle();
                Log.Information(messageTemplate: "New moto created");
                Selection();
                break;
            case "2":
                motorcycle.GetMotorcycles();
                Log.Information(messageTemplate: $"Process of displaying moto information started");
                Log.Information(messageTemplate: "User viewed all motos");
                Selection();
                break;
            case "3":
                motorcycle.GetMotorcycleByID();
                Log.Information(messageTemplate: $"User found moto by it's Id");
                Selection();
                break;
            case "4":
                motorcycle.UpdateMotorcycle();
                Log.Information(messageTemplate: $"User updated moto");
                Selection();
                break;
            case "5":
                motorcycle.DeleteMotorcycle();
                Log.Information(messageTemplate: $"User deleted moto");
                Selection();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Wrong selection");
                break;
        }
    } 
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong");
}
finally
{
    Log.Information($"Programm succesfully ended at: {Convert.ToString(time)}");
    Log.CloseAndFlush();
}