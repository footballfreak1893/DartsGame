using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Games
{
    class GameScoring
    {

        int punktestand = 0;
        int wurf = 0;
        string eingabekategorie;
        int[] wuerfe;
        string[] eingabewuerfe = new string[100];
        string eingabepfeile;
        string[] wuerfeString;
        int pfeile = 0;

        public void TrainingZahl()
        {
            Console.WriteLine("-----Training Zahl-----");
            Console.WriteLine("Zahl wählen");
            Console.WriteLine("Zurück zum Hauptmenü -->press exit");
            var eingabeX01 = Console.ReadLine();
            Console.Clear();

            bool canConvert = int.TryParse(eingabeX01, out int zahl);

            while (canConvert == false)
            {
                Console.WriteLine("Ungültiger Wert");
                Console.WriteLine("Punkezahl eingeben");
                eingabewuerfe[wurf] = Console.ReadLine();
                canConvert = int.TryParse(eingabeX01, out zahl);
            }
            
            if (eingabeX01 == "exit")
            {
                return;
            }
            
            Console.WriteLine("-----Zahl " + eingabeX01 + "-----");
            Console.WriteLine("-----Anzahl Pfeile wählen-----");
            Console.WriteLine("25 Pfeile -->press 25");
            Console.WriteLine("50 Pfeile -->press 50");
            Console.WriteLine("75 Pfeile -->press 75");
            Console.WriteLine("100 Pfeile -->press 100");

            var eingabepfeile = Console.ReadLine();
            int anzahlPfeile = Convert.ToInt32(eingabepfeile);
            wuerfeString = new string[anzahlPfeile];
            wuerfe = new int[anzahlPfeile];
           // Console.Clear();

            while (true)
            {
                if (eingabeX01 != "exit" && eingabepfeile != "25" && eingabepfeile != "50" && eingabepfeile != "75" && eingabepfeile != "100" && eingabeX01 !="reset")
                {
                    Console.WriteLine("-----Anzahl Pfeile wählen-----");
                    Console.WriteLine("25 Pfeile -->press 25");
                    Console.WriteLine("50 Pfeile -->press 50");
                    Console.WriteLine("75 Pfeile -->press 75");
                    Console.WriteLine("100 Pfeile -->press 100");
                    eingabepfeile = Console.ReadLine();
                    Console.Clear();
                }
                 if (eingabeX01 == "exit")
                {
                    return;
                }

                if (eingabeX01 == "reset")
                {
                    TrainingZahl();
                    return;
                }
                else
                { break; }
            }

            bool cannConvert = int.TryParse(eingabepfeile, out int pfeile);

            while (canConvert == false)
            {
                Console.WriteLine("Ungültiger Wert");
                Console.WriteLine("Pfeileanzahl eingeben");
                eingabewuerfe[wurf] = Console.ReadLine();
                cannConvert = int.TryParse(eingabepfeile, out pfeile);
            }

            Console.WriteLine("Zahl " + eingabeX01);
            Console.WriteLine("Anzahl Pfeile " + pfeile);

            for (int i = 0; i < wuerfeString.Length; i++)
            {
                string zahlString = Convert.ToString(i + 1);
                wuerfeString[i] = zahlString;
            }

            for (int wurf = 0; wurf < pfeile; wurf++)
            {
                Console.WriteLine(wuerfeString[wurf] + ".Pfeil -->Punkte eingeben");
                eingabewuerfe[wurf] = Console.ReadLine();

                //Überprüfung  reset, exit
                if (eingabewuerfe[wurf] == "reset")
                {
                    return; //-->funktioniert nicht korrekt
                }
                if (eingabewuerfe[wurf] == "exit")
                {
                    Console.Clear();
                    return;
                }
                //Überprüfung Datentyp 
                canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewuerfe[wurf] = Console.ReadLine();
                    canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);
                }
                punktestand = punktestand + wuerfe[wurf];

            }
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Spiel erneut starten -->press: reset");
            Console.WriteLine("Zurück zum Menü Highscore -->press exit");
            eingabekategorie = Console.ReadLine();
            Console.Clear();

            while (eingabekategorie != "SHA" && eingabekategorie != "exit")
            {
                Console.WriteLine("Ungültiger Wert");
                Console.WriteLine("Spiel erneut starten -->press: reset");
                Console.WriteLine("Zurück zum Menü Training Zahl -->press exit");
                eingabekategorie = Console.ReadLine();
                Console.Clear();
            }

            if (eingabekategorie == "exit")
            {
                return;
            }
            else if (eingabekategorie == "reset")
            {
                return;
            }
        }
    }
}
