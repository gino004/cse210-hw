using System;

public class PromptGenerator
{
   public List<string> _prompts = new List<string>();
   public PromptGenerator()
   {
      _prompts.Add("write something that encourages you today...");
      _prompts.Add("What would you like to do starting the day?");
      _prompts.Add("Who would you like to meet today?");
      _prompts.Add("What are the things you admire about your parents?");
   }
   public string GetRandomPrompt()
   {
      int numberRandom;
      Random random = new Random();
      numberRandom = random.Next(_prompts.Count);

      return _prompts[numberRandom];
   }
}