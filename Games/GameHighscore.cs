using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Games
{
    class GameHighscore
    {
        //vars
        int anzeigezahl = 1;
        int punktestand = 0;
        int wurf;
        string eingabekategorie;
        int runde = 1;
        int[] wuerfe = new int[3];
        string[] eingabewuerfe = new string[3];
        string[] wuerfeString = { "1", "2", "3" };
        int apunktestand = 0;
       Starting s = new Starting();

        public void High()
        {
            Console.WriteLine("-----Highscore-----");
            Console.WriteLine("Spiel wählen");
            Console.WriteLine("7 Runden -->press 7");
            Console.WriteLine("15 Runden -->press 15");
            Console.WriteLine("20 Runden -->press 15");
            //Console.WriteLine("Rundenzahl selbst festlegen -->press Eigene Zahl");
            Console.WriteLine("Zurück zum Hauptmenü -->press exit");
            var eingabeX01 = Console.ReadLine();
            Console.Clear();
            while (true)
            {
                if (eingabeX01 != "7" && eingabeX01 != "exit" && eingabeX01 != "15" )
                {
                    Console.WriteLine("Spiel wählen");
                    Console.WriteLine("7 Runden -->press 7");
                    Console.WriteLine("15 Runden -->press 15");
                    Console.WriteLine("20 Runden -->press 15");
                    Console.WriteLine("Rundenzahl selbst festlegen -->press Eigene Zahl");
                    Console.WriteLine("Zurück zum Hauptmenü -->press exit");
                    eingabeX01 = Console.ReadLine();
                    Console.Clear();
                }
                else if (eingabeX01 == "exit")
                {
                    return;
                }

                else
                {
                    GameHigh(eingabeX01);
                    High();
                    return;
                }
            }
        }

        public void GameHigh(string eingabeX01)
        {
            int runde;
            //Parsen der eingegebenen Rundenzahl

            Console.WriteLine("-----" + eingabeX01 + " Runden-----");
            int rundenzahl = Convert.ToInt16(eingabeX01);

            for (runde =1; runde<= rundenzahl; runde++)
            {
                for (int wurf = 0; wurf <= 2; wurf++)
                {
                    Console.WriteLine("Runde " + runde);
                    
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
                    bool canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);

                    while (canConvert == false)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabewuerfe[wurf] = Console.ReadLine();
                        canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);
                    }

                    //Console.Clear();
                      apunktestand = wuerfe[0] + wuerfe[1] + wuerfe[2];
                    //punktestand = punktestand + apunktestand;
                }

                punktestand = punktestand + apunktestand;
                Console.WriteLine("Punktestand Gesamt: " + punktestand);
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
                Console.WriteLine("Zurück zum Menü SHA -->press exit");
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

