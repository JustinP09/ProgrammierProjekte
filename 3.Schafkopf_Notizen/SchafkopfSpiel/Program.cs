using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchafkopfSpiel
{
    internal class Program
    {

        static void Spiel(int[,] spiel, string[] spieler)
        {
            for (int i = 0; i < spiel.GetLength(0); i++)
            {
                for (int j = 0; j < spiel.GetLength(1); j++)
                {
                    Console.Write($"Punkte von {spieler[j]} in Runde {i + 1}: ");
                    spiel[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                if (!IstRichtig(spiel, i))
                {
                    Console.WriteLine("Stopp Falsche Eingabe! Nochmal eingeben");
                    i--;
                }
                Console.WriteLine();
            }
        }
        static bool IstRichtig(int[,] a, int n)
        {
            int[] b = new int[a.GetLength(1)];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[n, i];
            }
            int c = b[0];
            for (int i = 1; i < b.Length; i++)
            {
                c += b[i];
            }
            if (c == 0)
            {
                return true;
            }
            return false;
        }
        static void Striche(int anzSpieler)
        {
            for(int i = 0;i< anzSpieler*20; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        static void Ausgabe(int[,] spiel, string[] spieler, int anzSpieler)
        {
            bool abbruch = false;
            while (!abbruch)
            {
                Striche(anzSpieler);
                Console.Write("         ");
                foreach(string s in spieler)
                {
                    Console.Write($"{s,15}");
                }
                Console.WriteLine();
                for (int i = 0; i < spiel.GetLength(0); i++)
                {
                    string ausg = $"Spiel {i + 1}: ";
                    for(int j = 0; j < spiel.GetLength(1); j++)
                    {
                        ausg += $"{spiel[i, j],15}";
                    }
                    Console.WriteLine(ausg);
                }
                int[] summe = new int[spiel.GetLength(1)];
                Console.Write("Gesamt: ");
                for (int i = 0;i < spiel.GetLength(1); i++)
                {
                    for(int j = 0;j < spiel.GetLength(0); j++)
                    {
                        summe[i] += spiel[j, i];
                    }
                    Console.Write($"{summe[i],16}");
                }
                Console.WriteLine();
                Striche(anzSpieler);
                Console.ReadLine();
                abbruch = true;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Wie viele Spieler?: ");
            int anzSpieler = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele Spiele willst du spielen?: ");
            int anzSpiele = Convert.ToInt32(Console.ReadLine());

            string[] spieler = new string[anzSpieler];
            int[,] spiel = new int[anzSpiele, anzSpieler];

            for (int i = 0; i < spieler.Length; i++)
            {
                Console.Write($"Name von Spieler {i + 1}: ");
                spieler[i] = Console.ReadLine();
            }
            Console.Clear();
            Spiel(spiel, spieler);
            Ausgabe(spiel, spieler, anzSpieler);

        }
    }
}
