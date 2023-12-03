using System;
using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Bienvenido a la");
        Console.WriteLine($"{_name} {_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Gracias por tu ezfuerzo.");
    }
    public void ShowSpinner(int seconds)
    {   
        _duration = seconds;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            Console.Write("+");
              
            Thread.Sleep(500);

            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\\");
        }
    }
    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("La sesion empieza");
            Thread.Sleep(1000);
            Console.Write("3");
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("2");
            Console.Write("\b \b");
            Thread.Sleep(1000);
            Console.Write("1");
            Console.Write("\b \b");
        }
    }

}