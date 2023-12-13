class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Goal Manager!");
        while (true)
        {
            ShowMenu();
            int option = Convert.ToInt32(Console.ReadLine());
            ExecuteOption(option);
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Points: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("------ Goal Names ------");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("------ Goal Details ------");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Enter short name for the goal: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter the description for the goal: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points associated with the goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Goal newGoal;

        switch (goalType.ToLower())
        {
            case "simple":
                newGoal = new SimpleGoal(shortName, description, points);
                break;
            case "eternal":
                newGoal = new EternalGoal(shortName, description, points);
                break;
            case "checklist":
                newGoal = new ChecklistGoal(shortName, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type. Creating a default Simple goal.");
                newGoal = new SimpleGoal(shortName, description, points);
                break;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully.");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Enter the number of the goal to record an event: ");
        int index = Convert.ToInt32(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _score += _goals[index].CalculatePoints();
            _goals[index].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index. Please select a valid goal number.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        try
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Parse the line and create the corresponding goal
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = Convert.ToInt32(parts[3]);

                    Goal newGoal;

                    switch (goalType.ToLower())
                    {
                        case "simple":
                            newGoal = new SimpleGoal(shortName, description, points);
                            break;
                        case "eternal":
                            newGoal = new EternalGoal(shortName, description, points);
                            break;
                        case "checklist":
                            newGoal = new ChecklistGoal(shortName, description, points);
                            break;
                        default:
                            Console.WriteLine($"Invalid goal type in line: {line}. Skipping this goal.");
                            continue;
                    }

                    _goals.Add(newGoal);
                }
                Console.WriteLine("Goals loaded successfully.");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Existing goals file not found. Creating a new one.");
        }
    }

    private void ShowMenu()
    {
        Console.WriteLine("------ Goal Manager Menu ------");
        Console.WriteLine("1. Display Player Info");
        Console.WriteLine("2. List Goal Names");
        Console.WriteLine("3. List Goal Details");
        Console.WriteLine("4. Create New Goal");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Save Goals");
        Console.WriteLine("7. Load Goals");
        Console.WriteLine("8. Exit");
        Console.Write("Select an option: ");
    }

    private void ExecuteOption(int option)
    {
        switch (option)
        {
            case 1:
                DisplayPlayerInfo();
                break;
            case 2:
                ListGoalNames();
                break;
            case 3:
                ListGoalDetails();
                break;
            case 4:
                CreateGoal();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                SaveGoals();
                break;
            case 7:
                LoadGoals();
                break;
            case 8:
                Console.WriteLine("Exiting Goal Manager. Goodbye!");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option. Please select a valid option.");
                break;
        }
    }
}