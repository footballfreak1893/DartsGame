using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameX01
    {
        Starting starting = new Starting();

        public void X01()
        {
           
            while (true)
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
                
                 if (eingabeX01 == "exit")
                {
                    Console.Clear();
                    return;
                }

                else if (eingabeX01 =="501")
                {
                    Console.Clear();
                    X01Modus("501");
                }

                else if (eingabeX01 == "301")
                {
                    Console.Clear();
                    X01Modus("301");
                }

                else if (eingabeX01 == "201")
                {
                    Console.Clear();
                    X01Modus("201");
                }

                else if (eingabeX01 == "201")
                {
                    Console.Clear();
                    X01Modus("201");
                }
                 else
                {
                    starting.InvalidValue();
                }
            }
        }
        public void X01Modus(string eingabeX01)
        {


            while (true)
            {
                Console.WriteLine("-----" + eingabeX01 + "-----");
                Console.WriteLine("Modus auswählen");
                Console.WriteLine("Single Out -->press SO");
                Console.WriteLine("Double Out -->press DO");
                Console.WriteLine("Master Out -->press MO");
                Console.WriteLine("Zurück zum X01 -->press exit");
                string modus = Console.ReadLine();
               
                 if (modus == "SO")
                {
                    SX01(eingabeX01);
                }
                else if (modus == "DO")
                {

                    X01Doubleout(eingabeX01);

                }
                else if (modus == "MO")
                {
                   
                }
                else
                {
                    starting.InvalidValue();
                }
            }

        }

        public void SX01(string eingabeX01)
        {
            int punktestand = 501;
            int wurf;   
            int runde = 1;
            int[] wuerfe = new int[3];
            string[] eingabewuerfe = new string[3];
            string[] wuerfeString = { "1", "2", "3" };
   

            Console.WriteLine("-----" + eingabeX01 + " Single Out-----");

            punktestand = Convert.ToInt32(eingabeX01);

            while (punktestand != 0)
            {
                Console.WriteLine("Runde " + runde);

                for (wurf = 0; wurf <= 2; wurf++)
                {

                    Console.WriteLine("Runde " + runde);
                    Console.WriteLine(wuerfeString[wurf] + ".Pfeil -->Punkte eingeben");
                    eingabewuerfe[wurf] = Console.ReadLine();

                    //Überprüfung  reset, exit
                    if (eingabewuerfe[wurf] == "reset")
                    {
                        //Console.Clear();
                        //SX01(eingabeX01);
                        //return;
                    }
                    if (eingabewuerfe[wurf] == "exit")
                    {
                        Console.Clear();
                        return;
                    }
                    wuerfe[wurf]=starting.ÜberprüfungDatentyp();

                    //Überprüfung Maximum/ Minimum
                    while (wuerfe[wurf] > 60 || wuerfe[wurf] < 0)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabewuerfe[wurf] = Console.ReadLine();


                        ////Überprüfung Datentyp
                        //canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);

                        //while (canConvert == false)
                        //{
                        //    Console.WriteLine("Ungültiger Wert");
                        //    Console.WriteLine("Punkezahl eingeben");
                        //    eingabewuerfe[wurf] = Console.ReadLine();
                        //    canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);
                        //}
                    }

                    if ((punktestand - wuerfe[wurf]) < 0)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        punktestand = punktestand - 0;
                        Console.WriteLine("Punktestand: " + punktestand);
                    }
                    else
                    {
                        punktestand = punktestand - wuerfe[wurf];
                        Console.WriteLine("Punktestand: " + punktestand);
                    }
                    if (punktestand == 0)
                    {
                        break;
                    }
                }
                runde++;
               
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
                Console.Clear();
                SX01(eingabeX01);
                return;
            }
            else
            {
                return;
            }

        }
            
        public void X01Doubleout(string eingabeX01)
        {
            
            int punktestand = 501;
            int wurf;
            
            int runde = 1;
            int[] wuerfe = new int[3];
            string[] eingabewuerfe = new string[3];
            string[] wuerfeString = { "1", "2", "3" };
           


            Console.WriteLine("-----" + eingabeX01 + " Double Out-----");

            punktestand = Convert.ToInt32(eingabeX01);

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
                    {    Console.Clear();
                        X01Doubleout(eingabeX01);
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

                    //Überprüfung Maximum/Minimum                  
                    while (wuerfe[wurf] > 60 || wuerfe[wurf] < 0)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabewuerfe[wurf] = Console.ReadLine();


                        //Überprüfung Datentyp
                        canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);

                        while (canConvert == false)
                        {
                            Console.WriteLine("Ungültiger Wert");
                            Console.WriteLine("Punkezahl eingeben");
                            eingabewuerfe[wurf] = Console.ReadLine();
                            canConvert = int.TryParse(eingabewuerfe[wurf], out wuerfe[wurf]);
                        }
                    }

                     if ((punktestand - wuerfe[wurf] )<  0)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        punktestand = punktestand - 0;
                        Console.WriteLine("Punktestand: " + punktestand);
                    }
                    else
                    {
                        punktestand = punktestand - wuerfe[wurf];
                        Console.WriteLine("Punktestand: " + punktestand);
                    }
                    if (punktestand == 0)
                    {
                        break;
                    }
                }

                runde++;
            }
            Console.WriteLine("Spiel beendet");
            Console.WriteLine("Spiel erneut starten -->press: reset");
            Console.WriteLine("Zurück zum Menü X01 -->press exit");
            eingabeX01 = Console.ReadLine();
            Console.Clear();

        }

        }
    }



