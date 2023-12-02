using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Actividad de Respiración", "Esta actividad le ayudará a relajarse al inhalar y exhalar lentamente. Despeja tu mente y concéntrate en tu respiración.");
        ReflectingActivity reflecting = new ReflectingActivity("Actividad de Reflección", "Esta actividad te ayudará a reflexionar sobre momentos de tu vida en los que has demostrado fortaleza y resiliencia. Esto te ayudará a reconocer el poder que tienes y cómo puedes usarlo en otros aspectos de tu vida.");

        bool keep = true;
        string Salir = "";

        while (keep == true)
        {
            Console.WriteLine("Menú de Opciones");

            if (DisplayMenu() == "1")
            {
                Console.WriteLine(breathing.Run());


            }
        }
    }
    static string DisplayMenu()
    {
        string display;

        Console.WriteLine("1. Empezar con la Actividad de Respiración");
        Console.WriteLine("2. Empezar con la Actividad de Reflección");
        Console.WriteLine("3. Empezar con la Actividad de la Lista");
        Console.WriteLine("4. Salir");

        return display = Console.ReadLine();
    }
}