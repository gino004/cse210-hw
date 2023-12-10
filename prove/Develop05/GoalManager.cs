using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        int choice;
        do
        {
            DisplayMenu();
            choice = GetUserChoice();
            ProcessChoice(choice);
        } while (choice != 6);
    }

    private void DisplayMenu()
    {
        Console.WriteLine($"You have {_score} points\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("\nSelect from the menu: ");
    }

    private int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.Write("Invalid choice. Please enter a number between 1 and 6: ");
        }
        return choice;
    }

     private void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                ListGoalDetails();
                break;
            case 3:
                SaveGoals();
                break;
            case 4:
                LoadGoals();
                break;
            case 5:
                RecordEvent();
                break;
            case 6:
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

      private void CreateGoal()
    {
        Console.Write("Enter goal type (Simple/Eternal/Checklist): ");
        string goalType = Console.ReadLine().ToLower();

        Console.Write("Enter short name: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (goalType)
        {
            case "simple":
                goal = new SimpleGoal(shortName, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(shortName, description, points);
                break;
            case "checklist":
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(shortName, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

     private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }


    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}\n");
    }

    public void ListGoalNames()
    {
        // Enumera los nombres de cada objetivo
    }

    public void RecordEvent()
    {
        // Pregunta al usuario qué objetivo ha cumplido y registra el evento
    }

    public void SaveGoals()
    {
         try
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }

            Console.WriteLine("Goals saved successfully.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving goals: {ex.Message}");
    }
    }

    public void LoadGoals()
    {
         try
    {
        _goals.Clear(); // Limpiar la lista actual antes de cargar desde el archivo

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = CreateGoalFromLine(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading goals: {ex.Message}");
    }
}

private Goal CreateGoalFromLine(string line)
{
    string[] parts = line.Split(':');
    if (parts.Length != 2)
    {
        // Manejar líneas incorrectas según sea necesario
        return null;
    }

    string[] values = parts[1].Split(',');

    // Verificar que hay suficientes valores para crear un objetivo
    if (values.Length < 3)
    {
        // Manejar líneas incorrectas según sea necesario
        return null;
    }

    string type = parts[0];
    string shortName = values[0];
    string description = values[1];
    int points = int.Parse(values[2]);

    switch (type)
    {
        case nameof(SimpleGoal):
            return new SimpleGoal(shortName, description, points);
        case nameof(EternalGoal):
            return new EternalGoal(shortName, description, points);
        case nameof(ChecklistGoal):
            // Verificar que hay suficientes valores para un objetivo de lista de verificación
            if (values.Length >= 6)
            {
                int amountCompleted = int.Parse(values[3]);
                int target = int.Parse(values[4]);
                int bonus = int.Parse(values[5]);
                return new ChecklistGoal(shortName, description, points, target, bonus);
            }
            else
            {
                // Manejar líneas incorrectas según sea necesario
                return null;
            }
        default:
            // Manejar tipos desconocidos según sea necesario
            return null;
    }
    }
}