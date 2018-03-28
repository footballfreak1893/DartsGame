using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameX01
    {
        Starting s1 = new Starting();

        public void X01()
        {
            Console.WriteLine("-----X01-----");
            Console.WriteLine("Spiel wählen");
            Console.WriteLine("501 -->press 501");
            Console.WriteLine("301 -->press 301");
            Console.WriteLine("201 -->press 201");
            Console.WriteLine("170 -->press 170");
            Console.WriteLine("Zurück zum Hauptmenü -->press exit");
            var eingabeX01 = Console.ReadLine();
            Console.Clear();
            while (true)
            {
                if (eingabeX01 != "501" && eingabeX01 != "exit" && eingabeX01 != "301" && eingabeX01 != "201" && eingabeX01 != "170")
                {
                    Console.WriteLine("Spiel wählen");
                    Console.WriteLine("501 -->press 501");
                    Console.WriteLine("301 -->press 301");
                    Console.WriteLine("201 -->press 201");
                    Console.WriteLine("170 -->press 170");
                    Console.WriteLine("Zurück zum Hauptmenü -->press exit");
                    eingabeX01 = Console.ReadLine();
                    Console.Clear();
                }
                else if (eingabeX01 == "exit")
                {
                    Starting.Start();
                }

                else
                {
                    SX01(eingabeX01);
                    return;
                }
            }
        }

        public void SX01(string eingabeX01)
        {
            int punkte=0;
            Console.WriteLine("-----" + eingabeX01 + "-----");
            int punktestand;
            punktestand = Convert.ToInt32(eingabeX01);

            while (punktestand != 0)
            {
                Console.WriteLine("Punkestand " + punktestand);
                Console.WriteLine("Punkezahl eingeben");
                var eingabepunkte = Console.ReadLine();
                

                if (eingabepunkte == "reset")
                {
                    return;
                }
                if (eingabepunkte == "exit")
                {
                    break;
                }

                //Überprüfung Zahl
                bool canConvert = int.TryParse(eingabepunkte, out punkte);

                while (canConvert == false)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabepunkte = Console.ReadLine();
                    canConvert = int.TryParse(eingabepunkte, out punkte);
                }

                //Überprüfung Maximum/Minimum                  
                while (punkte > 180 || punkte < 0)
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Punkezahl eingeben");
                    eingabepunkte = Console.ReadLine();
                    Console.Clear();

                    //Überprüfung Zahl
                    canConvert = int.TryParse(eingabepunkte, out punkte);

                    while (canConvert == false)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabepunkte = Console.ReadLine();
                        canConvert = int.TryParse(eingabepunkte, out punkte);
                    }
                }
                //Überprüfen, das Methode beendet wird

                //punktestand = punktestand - punkte;
                if (( punktestand - punkte) < 0)
                {
                    Console.WriteLine("Ungültiger Wert");
                    punktestand = punktestand - 0;
                }
                else
                {
                    punktestand = punktestand - punkte;
                }
               
               
                
            }
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Spiel erneut starten -->press: reset");
            Console.WriteLine("Zurück zum Menü X01 -->press exit");
            eingabeX01 = Console.ReadLine();
            Console.Clear();

            while (eingabeX01 != "reset" && eingabeX01 != "exit")
            {
                Console.WriteLine("Ungültiger Wert");
                Console.WriteLine("Zurück zum Menü X01 -->press X01");
                Console.WriteLine("Zurück zum Hauptmenü -->press exit");
                eingabeX01 = Console.ReadLine();
                Console.Clear();
            }
            if (eingabeX01 == "reset")
            {
                return;
            }
            else
            {
                X01();
            }
        }

        public void X01Doubleout()
        {
            int anzeigezahl = 1;
            int punktestand = 501;
            int wurf;
            string eingabekategorie;
            int runde = 1;
            int[] wuerfe = new int[3];
            string[] eingabewuerfe = new string[3];
            string[] wuerfeString = { "1", "2", "3" };
           int punkte = 0;
            int gesamt = 0;
            

            //Console.WriteLine("-----" + eingabeX01 + "-----");
            
            //punktestand = Convert.ToInt32(eingabeX01);

            while (punktestand != 0)
            {
                for (wurf = 0; wurf <= 2; wurf++)
                {

                    Console.WriteLine("Runde " + runde);
                    //Console.WriteLine("Zuwerfende Zahl " + anzeigezahl);
                    Console.WriteLine(wuerfeString[wurf] + ".Pfeil -->Punkte eingeben");
                    eingabewuerfe[wurf] = Console.ReadLine();


                    //Überprüfung  reset, exit
                    if (eingabewuerfe[wurf] == "reset")
                    {
                        return; //-->funktioniert nicht korrekt
                    }
                    if (eingabewuerfe[wurf] == "exit")
                    {
                        //Console.Clear();
                        //SHA();
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

                    ////Überprüfung Zahl 
                    //while ((wuerfe[wurf] != anzeigezahl * 1) && (wuerfe[wurf] != anzeigezahl * 2) && (wuerfe[wurf] != anzeigezahl * 3) && (wuerfe[wurf] != 0) && eingabewuerfe[wurf] != "exit" && eingabewuerfe[wurf] != "reset")
                    //{
                    //    Console.WriteLine("Ungültige Zahl: ");
                    //    Console.WriteLine("Eingabe wiederholen");
                    //    eingabewuerfe[wurf] = Console.ReadLine();
                    //    wuerfe[wurf] = Convert.ToInt16(eingabewuerfe[wurf]);
                    //}


                    //Console.Clear();
                    punktestand = punktestand - wuerfe[wurf];
                    
                    //gesamt = wuerfe[0] + wuerfe[1] + wuerfe[2];

                    Console.WriteLine("Punktestand: " + punktestand);

                    ////Überprüfung Maximum/Minimum                  
                    //while (punkte > 180 || punkte < 0)
                    //{
                    //    Console.WriteLine("Ungültiger Wert");
                    //    Console.WriteLine("Punkezahl eingeben");
                    //    eingabepunkte = Console.ReadLine();
                    //    Console.Clear();

                    //    //Überprüfung Zahl
                    //    canConvert = int.TryParse(eingabepunkte, out punkte);

                    //    while (canConvert == false)
                    //    {
                    //        Console.WriteLine("Ungültiger Wert");
                    //        Console.WriteLine("Punkezahl eingeben");
                    //        eingabepunkte = Console.ReadLine();
                    //        canConvert = int.TryParse(eingabepunkte, out punkte);
                    //    }
                    //}

                    if ((punktestand - wuerfe[wurf]) < 0)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        punktestand = punktestand - 0;
                    }
                    else
                    {
                        punktestand = punktestand - wuerfe[wurf];
                    }
                }
                //Console.WriteLine("Punktestand: " + punktestand);


            }
        }
    }

}
