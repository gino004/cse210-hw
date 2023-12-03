using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity(int count, string name, string description) : base(name, description)
    {
        _count = count;
        
        _prompts.Add("¿Quiénes son las personas que aprecias?");
        _prompts.Add("¿Cuáles son sus puntos fuertes personales?");
        _prompts.Add("¿Quiénes son las personas a las que has ayudado esta semana?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("¿Quiénes son algunos de tus héroes personales?");
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