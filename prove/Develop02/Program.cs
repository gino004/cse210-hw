using System;
using System.IO;

class Program
{
  static void Main(string[] args)
  {
    PromptGenerator pg = new PromptGenerator();
    Journal journal = new Journal();
    string pro_ = pg.GetRandomPrompt();
    string _no;

    _no = Display_01();

    if (_no == "1")
    {

      Console.WriteLine($"{pro_}");
      _no = Console.ReadLine();

      Entry en = new Entry();
      en._date = DateTime.Now.ToString();
      en._entryText = _no;
      en._promptText = pro_;
      journal.AddEntry(en);
    }

    if (_no == "2")
    {

      journal.DisplayAll();



    }


  }


  static string Display_01()
  {

    string display;

    Console.WriteLine("Write 1");
    Console.WriteLine("Display 2");
    Console.WriteLine("Load 3");
    Console.WriteLine("Save 4");
    Console.WriteLine("Quit 5");

    return display = Console.ReadLine();


  }


}