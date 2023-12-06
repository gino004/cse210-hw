using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Actividad de Respiración", "Esta actividad le ayudará a relajarse al inhalar y exhalar lentamente. Despeja tu mente y concéntrate en tu respiración.");
        ReflectingActivity reflecting = new ReflectingActivity("Actividad de Reflección", "Esta actividad te ayudará a reflexionar sobre momentos de tu vida en los que has demostrado fortaleza y resiliencia. Esto te ayudará a reconocer el poder que tienes y cómo puedes usarlo en otros aspectos de tu vida.");
        ListingActivity listing = new ListingActivity(50, "Actividad de Listado", "Esta actividad te ayudará a reflexionar sobre las cosas buenas de tu vida al hacerte enumerar tantas cosas como puedas en un área determinada.");
        bool keep = true;
        while (keep == true)
        {
            Console.WriteLine("Menú de Opciones");

            string display; //se crea una variable display.

            display = DisplayMenu(); // aqui se le asigna el valor del metodo DisplayMenu para asi usarlo abajo en el If.

            if (display == "1")
            {
                breathing.Run();
            }
            if (display == "2")
            {
                reflecting.Run();
            }
            if (display == "3")
            {
                listing.Run();
            }
            if (display == "4")
            {
                keep = false;
            }
            else
            {
                break;
            }
        }
    }
    static string DisplayMenu()
    {
        Console.WriteLine("1. Empezar con la Actividad de Respiración");
        Console.WriteLine("2. Empezar con la Actividad de Reflección");
        Console.WriteLine("3. Empezar con la Actividad de la Lista");
        Console.WriteLine("4. Salir");

        return Console.ReadLine();
    }
}