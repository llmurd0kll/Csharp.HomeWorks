using HW._12.PayrollSystem;

Dictionary<int, string> titles = new Dictionary<int, string>()
       {
            { 1, "Junior Developer" },
            { 2, "Middle Developer" },
            { 3, "Senior Developer" },
            { 4, "Team Leader" },
            { 5, "Architect" }
       };

EngineerRepository engineer = new EngineerRepository(); 

Selection();


    void Selection()
    {
        Console.WriteLine("Please select your next action:\n To create engineer select: 1.\n " +
            "To see all your engineers select: 2.\n " +
            "To update your moto select: 3.\n " +
            "To delete your moto select: 4.\n " +
            "To exit select: 0");

        var answer = Console.ReadLine();

        switch (answer)
        {
            case "1":
                engineer.CreateEngineer();
            
                Selection();
                break;
            case "2":
                engineer.ViewAllEngineers();
                Selection();
                break;
            case "3":
                engineer.UpdateEngineer();
                Selection();
                break;
            case "4":
                engineer.DeleteEngineer();
                Selection();
                break;
            case "0":
                break;
            default:
                Console.WriteLine("Wrong selection");
                break;
        }
    }