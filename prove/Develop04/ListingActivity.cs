using System;
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int count, List<string> prompt, string name, string description) : base(name, description)
    {
        _count = count;
        _prompts = prompt;
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