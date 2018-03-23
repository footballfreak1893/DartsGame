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
        int wurf1 = 0;
        int wurf2 = 0;
        int wurf3 = 0;
        string eingabewurf1;
        string eingabewurf2;
        string eingabewurf3;
        string eingabekategorie;
        int runde;

        public void SHA()
        {
            Console.WriteLine("-----Shanghai-----");
            Console.WriteLine("Spielmodus auswählen:");
            Console.WriteLine("Classic --> press: classic");
            Console.WriteLine("Around the Clock --> press: clock"); //-->Kommt noch was
            Console.WriteLine("Spielmodus auswählen:"); //-->Kommt noch was
            Console.WriteLine("Zurück zum Hauptmenü: --> press: exit"); //-->Kommt noch was
            eingabekategorie = Console.ReadLine();

            while (true)
            {
                if (eingabekategorie != "classic" && eingabekategorie != "exit" && eingabekategorie != "clock")
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Classic --> press: classic");
                    Console.WriteLine("Spielmodus auswählen:"); //-->Kommt noch was
                    Console.WriteLine("Spielmodus auswählen:"); //-->Kommt noch was
                    eingabekategorie = Console.ReadLine();
                }
                else if (eingabekategorie == "classic")
                {
                    SHAClassic();

                }
                else if (eingabekategorie == "clock")
                {
                    ClockMenu(); //--> Soll Hauptmenü aufrufen
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
                Console.WriteLine("Runde " + runde);
                Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                Console.WriteLine("1. Pfeil -->Punkte eingeben");
                eingabewurf1 = Console.ReadLine();

                //Überprüfung 1 reset, exit
                if (eingabewurf1 == "reset")
                {
                    return;
                }
                if (eingabewurf1 == "exit")
                {
                    Starting.Start();
                }
                //Überprüfung Datentyp Wurf1
                bool canConvert = int.TryParse(eingabewurf1, out wurf1);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewurf1 = Console.ReadLine();
                    canConvert = int.TryParse(eingabewurf1, out wurf1);
                }
                //Überprüfung Zahl Wurf1
                while ((wurf1 != anzeigezahl * 1) && (wurf1 != anzeigezahl * 2) && (wurf1 != anzeigezahl * 3) && eingabewurf1 != "exit" && eingabewurf1 != "reset")
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    eingabewurf1 = Console.ReadLine();
                    wurf1 = Convert.ToInt16(eingabewurf1);
                }
                if (wurf2 > 0)
                {
                    anzeigezahl++;
                }
                Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);

                Console.WriteLine("2. Pfeil -->Punkte eingeben");
                eingabewurf2 = Console.ReadLine();

                //Überprüfung 2 reset, exit
                if (eingabewurf2 == "reset")
                {
                    return;
                }
                if (eingabewurf2 == "exit")
                {
                    Starting.Start();
                }

                //Überprüfung Datentyp Wurf2
                canConvert = int.TryParse(eingabewurf2, out wurf2);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewurf2 = Console.ReadLine();
                    canConvert = int.TryParse(eingabewurf2, out wurf2);
                }
                //Überprüfung Zahl Wurf2
                while ((wurf2 != anzeigezahl * 1) && (wurf2 != anzeigezahl * 2) && (wurf2 != anzeigezahl * 3))
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    eingabewurf2 = Console.ReadLine();
                    wurf2 = Convert.ToInt16(eingabewurf2);
                }
                if (wurf1 > 0)
                {
                    anzeigezahl++;
                }

                Console.WriteLine("3. Pfeil -->Punkte eingeben");
                eingabewurf3 = Console.ReadLine();

                //Überprüfung 3 reset, exit
                if (eingabewurf3 == "reset")
                {
                    return;
                }
                if (eingabewurf3 == "exit")
                {
                    Starting.Start();
                }

                //Überprüfung Datentyp Wurf3
                canConvert = int.TryParse(eingabewurf3, out wurf3);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewurf3 = Console.ReadLine();
                    canConvert = int.TryParse(eingabewurf3, out wurf3);
                }
                //Überprüfung Zahl Wurf3
                while ((wurf3 != anzeigezahl * 1) && (wurf3 != anzeigezahl * 2) && (wurf3 != anzeigezahl * 3))
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    eingabewurf3 = Console.ReadLine();
                    wurf3 = Convert.ToInt16(eingabewurf3);
                }
                if (wurf3 > 0)
                {
                    anzeigezahl++;
                }

                punktestand = punktestand + wurf1 + wurf2 + wurf3;
                Console.WriteLine("Punktestand: " + punktestand);

            }
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Erreichte Punkte " + punktestand);
            Console.WriteLine("Spiel erneut starten -->press SHA");
            Console.WriteLine("Zurück zum Hauptmenü -->press exit");
            string eingabemenu = Console.ReadLine();

            while (eingabemenu != "SHA" && eingabemenu != "exit")
            {
                Console.WriteLine("Ungültiger Wert");
                Console.WriteLine("Zurück zum Menü X01 -->press X01");
                Console.WriteLine("Zurück zum Hauptmenü -->press exit");
                eingabemenu = Console.ReadLine();
            }
            if (eingabemenu == "SHA")
            {
                return;
            }
            else
            {
                SHA();
            }
            Console.ReadKey();

        }

        public void ClockMenu()
        {
            Console.WriteLine("-----ClockMenu-----");
            Console.WriteLine("Spielmodus auswählen:");
            Console.WriteLine("3x Singletreffer --> press: 3s");
            //Console.WriteLine("Around the Clock --> press: clock"); //-->Kommt noch was
            //Console.WriteLine("Spielmodus auswählen:"); //-->Kommt noch was
            //Console.WriteLine("Zurück zum Hauptmenü: --> press: exit"); //-->Kommt noch was
            eingabekategorie = Console.ReadLine();

            while (true)
            {
                if (eingabekategorie != "3s" && eingabekategorie != "exit")
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Classic --> press: classic");
                    Console.WriteLine("Spielmodus auswählen:"); //-->Kommt noch was
                    Console.WriteLine("Spielmodus auswählen:"); //-->Kommt noch was
                    eingabekategorie = Console.ReadLine();
                }
                else if (eingabekategorie == "3s")
                {
                    TrippleSingle();

                }
                //else if (eingabekategorie == "clock")
                //{
                //    return; //--> Soll Hauptmenü aufrufen
                //}
                else if (eingabekategorie == "exit")
                {
                    return; //--> Soll Hauptmenü aufrufen
                }
            }
        }

        public void TrippleSingle()
        {
            Console.WriteLine("-----Around the Clock 3 Fach-----");
            runde = 1;
            while (anzeigezahl < 22)
            {
                Console.WriteLine("Runde " + runde);
                Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                Console.WriteLine("1. Pfeil -->Punkte eingeben");
                eingabewurf1 = Console.ReadLine();
                //Console.WriteLine();--> evtl leerzeichen

                //Überprüfung 1 reset, exit
                if (eingabewurf1 == "reset")
                {
                    return;
                }
                if (eingabewurf1 == "exit")
                {
                    break;
                    
                }
                //Überprüfung Datentyp Wurf1
                bool canConvert = int.TryParse(eingabewurf1, out wurf1);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewurf1 = Console.ReadLine();
                    canConvert = int.TryParse(eingabewurf1, out wurf1);
                }
                //Überprüfung Zahl Wurf1
                while (wurf1 != anzeigezahl && wurf1 != 0)
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                    eingabewurf1 = Console.ReadLine();
                    wurf1 = Convert.ToInt16(eingabewurf1);
                }

                if (wurf1 > 0)
                {
                    punktestand = punktestand + anzeigezahl;
                }
                Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);

                Console.WriteLine("2. Pfeil -->Punkte eingeben");
                eingabewurf2 = Console.ReadLine();

                //Überprüfung 2 reset, exit
                if (eingabewurf2 == "reset")
                {
                    return;
                }
                if (eingabewurf2 == "exit")
                {
                    break;
                }

                //Überprüfung Datentyp Wurf2
                canConvert = int.TryParse(eingabewurf2, out wurf2);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewurf2 = Console.ReadLine();
                    canConvert = int.TryParse(eingabewurf2, out wurf2);
                }
                //Überprüfung Zahl Wurf2
                while (wurf2 != anzeigezahl && wurf2 != 0)
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                    eingabewurf2 = Console.ReadLine();
                    wurf2 = Convert.ToInt16(eingabewurf2);
                }
                if (wurf2 > 0)
                {
                    punktestand = punktestand + anzeigezahl;
                }


                Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                Console.WriteLine("3. Pfeil -->Punkte eingeben");
                eingabewurf3 = Console.ReadLine();

                //Überprüfung 3 reset, exit
                if (eingabewurf3 == "reset")
                {
                    return;
                }
                if (eingabewurf3 == "exit")
                {
                    ClockMenu();
                }

                //Überprüfung Datentyp Wurf3
                canConvert = int.TryParse(eingabewurf3, out wurf3);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabewurf3 = Console.ReadLine();
                    canConvert = int.TryParse(eingabewurf3, out wurf3);
                }
                //Überprüfung Zahl Wurf3
                while (wurf3 != anzeigezahl && wurf3 != 0)
                {
                    Console.WriteLine("Ungültige Zahl: ");
                    Console.WriteLine("Eingabe wiederholen");
                    Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                    eingabewurf2 = Console.ReadLine();
                    wurf2 = Convert.ToInt16(eingabewurf2);
                }
                if (wurf3 > 0)
                {
                    punktestand = punktestand + anzeigezahl;
                }


                anzeigezahl++;
                runde++;
                Console.WriteLine("Punkestand " + punktestand);

            }
            
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Erreichte Punkte " + punktestand);
            Console.WriteLine("Spiel erneut starten -->press 3s");
            Console.WriteLine("Zurück zum Hauptmenü -->press exit");
            string eingabemenu = Console.ReadLine();

            while (eingabemenu != "SHA" && eingabemenu != "exit")
            {
                Console.WriteLine("Ungültiger Wert");
                Console.WriteLine("Zurück zum Menü X01 -->press X01");
                Console.WriteLine("Zurück zum Hauptmenü -->press exit");
                eingabemenu = Console.ReadLine();
            }
            if (eingabemenu == "3s")
            {
                return;
            }
            else
            {
                ClockMenu();
            }
            Console.ReadKey();

        }
    }
}
