using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private string v;

    public ListingActivity(int count, List<string> prompt, string name, string description) : base(name, description)
    {
        _count = count;
        
        _prompts = prompt;
        prompt.Add("¿Quiénes son las personas que aprecias?");
        prompt.Add("¿Cuáles son sus puntos fuertes personales?");
        prompt.Add("¿Quiénes son las personas a las que has ayudado esta semana?");
        prompt.Add("When have you felt the Holy Ghost this month?");
        prompt.Add("¿Quiénes son algunos de tus héroes personales?");
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        int numberRandom;
        Random random = new Random();
        numberRandom = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[numberRandom]);
    }
    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}