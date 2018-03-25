using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameShanghai
    {
        //vars
        int anzeigezahl = 1;
        int punktestand = 0;
        int wurf;
        string eingabekategorie;
        int runde;
        int[] wuerfe = new int[3];
        string[] eingabewuerfe = new string[3];
        string[] wuerfeString = { "1", "2", "3" };

        public void SHA()
        {
            Console.WriteLine("-----Shanghai-----");
            Console.WriteLine("Spielmodus auswählen:");
            Console.WriteLine("Classic --> press: classic");
            Console.WriteLine("Around the Clock --> press: clock");
            Console.WriteLine("Spielmodus auswählen:"); 
            Console.WriteLine("Zurück zum Hauptmenü: --> press: exit"); 
            eingabekategorie = Console.ReadLine();

            while (true)
            {
                if (eingabekategorie != "classic" && eingabekategorie != "exit" && eingabekategorie != "clock")
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Classic --> press: classic");
                    Console.WriteLine("Around the Clock --> press: clock");
                    Console.WriteLine("Zurück zum Hauptmenü: --> press: exit");
                    eingabekategorie = Console.ReadLine();
                }
                else if (eingabekategorie == "classic")
                {
                    SHAClassic();
                }
                else if (eingabekategorie == "clock")
                {
                    ClockMenu();
                }
                else if (eingabekategorie == "exit")
                {
                    return; //--> Soll Hauptmenü aufrufen
                }
            }
        }

        public void SHAClassic()
        {
            Console.WriteLine("-----SHA Classic-----");

            for (runde = 1; runde < 8; runde++)
            {
                classicüberprüfungWurf(runde);
            }
            void classicüberprüfungWurf(int runde)
            {
                for (int wurf = 0; wurf <= 2; wurf++)
                {
                    Console.WriteLine("Runde " + runde);
                    Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                    Console.WriteLine(wuerfeString[wurf] + ".Pfeil -->Punkte eingeben");
                    eingabewuerfe[wurf] = Console.ReadLine();

                    //Überprüfung  reset, exit
                    if (eingabewuerfe[wurf] == "reset")
                    {
                        return; //Funktioniert nicht
                    }
                    if (eingabewuerfe[wurf] == "exit")
                    {
                        break; //Funktioniert nicht
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
                }

                //Überprüfung Zahl 
                while ((wuerfe[wurf] != anzeigezahl * 1) && (wuerfe[wurf] != anzeigezahl * 2) && (wuerfe[wurf] != anzeigezahl * 3) && (wuerfe[wurf] != 0) && eingabewuerfe[wurf] != "exit" && eingabewuerfe[wurf] != "reset")
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    eingabewuerfe[wurf] = Console.ReadLine();
                    wuerfe[wurf] = Convert.ToInt16(eingabewuerfe[wurf]);
                }
                if (wuerfe[wurf] > 0)
                {
                    anzeigezahl++;
                }
                punktestand = punktestand + wuerfe[0] + wuerfe[1] + wuerfe[2];
                Console.WriteLine("Punktestand: " + punktestand);
                return; //--> Wichtig

            }
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Spiel erneut starten -->press: reset");
            Console.WriteLine("Zurück zum Menü SHA -->press exit");
            eingabekategorie = Console.ReadLine();
        }
        

        public void ClockMenu()
        {
            Console.WriteLine("-----ClockMenu-----");
            Console.WriteLine("Spielmodus auswählen:");
            Console.WriteLine("3x Singletreffer --> press: 3s");
            eingabekategorie = Console.ReadLine();

            while (true)
            {
                if (eingabekategorie != "3s" && eingabekategorie != "exit")
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Spielmodus auswählen:");
                    Console.WriteLine("3x Singletreffer --> press: 3s");
                    eingabekategorie = Console.ReadLine();
                }
                else if (eingabekategorie == "3s")
                {
                    TrippleSingle();

                }
                else if (eingabekategorie == "clock")
                {
                    return; //--> Soll Hauptmenü aufrufen
                }
                else if (eingabekategorie == "exit")
                {
                    return; //--> Soll Hauptmenü aufrufen
                }
            }
        }

        public void TrippleSingle()
        {
            Console.WriteLine("-----Around the Clock 3 Fach-----");

            while (anzeigezahl < 22)
            {
                trippleüberprüfungWurf(runde);
            }
            void trippleüberprüfungWurf(int runde)
            {
                for (int wurf = 0; wurf <= 2; wurf++)
                {
                    Console.WriteLine("Runde " + runde);
                    Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                    Console.WriteLine(wuerfeString[wurf] + ".Pfeil -->Punkte eingeben");
                    eingabewuerfe[wurf] = Console.ReadLine();

                    //Überprüfung  reset, exit
                    if (eingabewuerfe[wurf] == "reset")
                    {
                        return;
                    }
                    if (eingabewuerfe[wurf] == "exit")
                    {
                        Starting.Start();
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
                }

                //Überprüfung Zahl 
                while ((wuerfe[wurf] != anzeigezahl) && (wuerfe[wurf] != 0) && eingabewuerfe[wurf] != "exit" && eingabewuerfe[wurf] != "reset")
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    eingabewuerfe[wurf] = Console.ReadLine();
                    wuerfe[wurf] = Convert.ToInt16(eingabewuerfe[wurf]);
                }
                if (wuerfe[wurf] > 0)
                {
                    anzeigezahl++;
                }
                punktestand = punktestand + wuerfe[0] + wuerfe[1] + wuerfe[2];
                Console.WriteLine("Punktestand: " + punktestand);
                return; //--> Wichtig
            }
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Spiel erneut starten -->press: reset");
            Console.WriteLine("Zurück zum Menü SHA -->press exit");
            eingabekategorie = Console.ReadLine();
        }
    }

}


