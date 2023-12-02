
public class BreathingActivity : Activity{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }
    public void Run()
    {   
        DisplayStartingMessage();
        Console.WriteLine("¿Cuánto tiempo, en segundos, te gustaría para tu sesión?");
        Console.ReadLine();
        Console.WriteLine("Preparate...");
        ShowSpinner(5);
        DisplayEndingMessage();
    }

}