using System.ComponentModel;

namespace SchiffeVersenken
{
    internal class Program
    {
        static int AbfrageSpielfeldGroesse()    //hier wird nach der Spielfeldgroesse abgefragt 
        {
            bool fehlerEingabe;
            int groesse;
            do
            {
                fehlerEingabe = true;
                Console.Write("Bitte geben Sie die gewünschte Spielfeld Groesse ein (5, 6, 7 Zeilen und Spalten): ");
                groesse = Convert.ToInt32(Console.ReadLine());
                if (groesse != 5 && groesse != 6 && groesse != 7)       //Wenn fehlerhafte Eingabe eingegeben wird, dann wiederhole
                {
                    Console.WriteLine("Ungueltige Eingabe, Bitte die Zahlen 5, 6 oder 7 eingeben!");
                    fehlerEingabe = false;
                }
            } while (!fehlerEingabe);
            return groesse;
        }
        static void PositioniereSchiff(int[,] spielfeld)
        {
            Random rand = new Random();
            int ausrichtung = rand.Next(2);      //0 fuer wagrecht 1 fuer senkrecht
            if (ausrichtung == 0)    //Damit mann nicht über den Spielfeldrand raus geht
            {
                int zeilenPosition = rand.Next(spielfeld.GetLength(0));
                int spaltnePosition = rand.Next(spielfeld.GetLength(1) - 2);

                for (int i = 0; i <= 2; i++)
                {
                    spielfeld[zeilenPosition, spaltnePosition + i] = 1;
                }
            }
            else
            {
                int zeilenPosition = rand.Next(spielfeld.GetLength(0) - 2);
                int spaltnePosition = rand.Next(spielfeld.GetLength(1));

                for (int i = 0; i <= 2; i++)
                {
                    spielfeld[zeilenPosition + i, spaltnePosition] = 1;
                }
            }
        }
        static void ZeichnenSpielfeld(int[,] spielfeld)
        {
            Console.Write(" ");
            for (int k = 1; k < spielfeld.GetLength(1) + 1; k++)   //erst Obereste Zeile Ausgeben (Spaltenbennenung)
            {
                Console.Write(" " + k);
            }
            Console.WriteLine();
            for (int i = 0; i < spielfeld.GetLength(0); i++)    //Jetzt Spielfeld Ausgeben 
            {
                Console.Write(i + 1);
                for (int j = 0; j < spielfeld.GetLength(1); j++)
                {
                    switch (spielfeld[i, j])
                    {
                        case 0:
                            Console.Write(" ~");
                            break;
                        case 1:
                            Console.Write(" ~");
                            break;
                        case 2:
                            Console.Write(" X");
                            break;
                        case 3:
                            Console.Write(" O");
                            break;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        static int LeseGanzzahl(int groesse)    //Für die Eingabe des Schusses 
        {
            int zahl;
            bool ganzzahl;
            do
            {
                string eing = Console.ReadLine();
                ganzzahl = int.TryParse(eing, out zahl);
                if (ganzzahl == false)
                {
                    Console.Write("Die Zahl ist KEINE Ganzzahl, erneute Eingabe: ");

                }
                if (zahl > groesse || zahl <= 0)
                {
                    Console.Write("Die Zahl muss im Spielfeldbereich liegen, erneute Eingabe: ");
                    ganzzahl = false;
                }
            } while (!ganzzahl);
            return zahl - 1;    //-1, weil bsp. Array[0,0] der Eingabe 1,1 entspricht

        }
        static void Main(string[] args)
        {
            int groesse = AbfrageSpielfeldGroesse();
            int[,] spielfeld = new int[groesse, groesse];
            int zuege = 0, treffer = 0;
            bool spielabbruch = true;
            PositioniereSchiff(spielfeld);

            do                  //Hauptgame Loop
            {               
                Console.Clear();
                ZeichnenSpielfeld(spielfeld);

                Console.Write("In welche Zeile moechtest Sie schiessen?: ");
                int schussZeile = LeseGanzzahl(groesse);
                Console.Write("In welche Spalte moechtest Sie schiessen?: ");
                int schussSpalte = LeseGanzzahl(groesse);

                switch (spielfeld[schussZeile, schussSpalte])
                {
                    case 0:
                        spielfeld[schussZeile, schussSpalte] = 3;   //3 für Fehlschuss
                        Console.WriteLine("Daneben!");
                        break;
                    case 1:
                        spielfeld[schussZeile, schussSpalte] = 2;   //2 für getroffenes Schiff
                        Console.WriteLine("Getroffen!");
                        treffer++;
                        break;
                }
                Console.ReadLine();
                zuege++;
                if (treffer == 3)
                {
                    spielabbruch = false;
                }
            } while (spielabbruch);
            Console.Clear();
            ZeichnenSpielfeld(spielfeld);
            Console.WriteLine($"Sie haben gewonnen und dafür {zuege} Züge benötigt.\n");
            Console.WriteLine("Taste zum Beenden drücken");
        }
    }
}