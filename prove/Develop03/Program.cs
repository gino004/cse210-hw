using System;
using System.IO.Compression;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Reference re = new Reference("Isaías", 53, 2);
        Scripture sc = new Scripture(re, "Porque subíra cual renuevo delante de él, y como raíz de tierra seca; no hay parecer en él ni hermosura; y cuando le yeamos, no habrá en el atractivo para que le deseemos");
        //Scripture sc = new Scripture(re,"uno dos tres");

        // string quit = "";

        // while(sc.IscompletelyHidden() == false || quit != "Finish"){

        //     Console.WriteLine(sc.GetDisplayText());
        //     quit = Console.ReadLine();
        //     sc.HideRandomWords(1);
        // }

        bool keep = true;
        string quit = "";

        while (keep == true)
        {
            Console.WriteLine(sc.GetDisplayText());
            quit = Console.ReadLine();
            sc.HideRandomWords(5);

            if (sc.IscompletelyHidden())
            {
                keep = false;
            }
            if (quit == "Finish")
            {
                keep = false;
            }

        }


    }
}