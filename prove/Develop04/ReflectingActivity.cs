
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, List<string> question, List<string> prompt) : base(name, description)
    {
        _prompts = prompt;
        _questions = question;
    }
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        int numberRandom;
        Random random = new Random();
        numberRandom = random.Next(_prompts.Count);
        return _prompts[numberRandom];
    }
    public string GetRandomQuestion()
    {
        int numberRandom;
        Random random = new Random();
        numberRandom = random.Next(_questions.Count);
        return _questions[numberRandom];
    }
    public void DisplayPrompt()
    {
       ShowSpinner(5);
       Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestion()
    {
       ShowSpinner(5); 
       Console.WriteLine(GetRandomQuestion());
    }



}