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
        public int wurf;
        string eingabeX01 = "";

        public string[] eingabewuerfe = new string[3];
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
                var modusPunkte = Console.ReadLine();
                Console.Clear();

                if (modusPunkte == "exit")
                {
                    Console.Clear();
                    return;
                }

                else if (modusPunkte == "501")
                {
                    Console.Clear();
                    X01Modus("501");
                }

                else if (modusPunkte == "301")
                {
                    Console.Clear();
                    X01Modus("301");
                }

                else if (modusPunkte == "201")
                {
                    Console.Clear();
                    X01Modus("201");
                }

                else if (modusPunkte == "170")
                {
                    Console.Clear();
                    X01Modus("170");
                }
                else
                {
                    starting.InvalidValue();
                }
            }
        }

        public void X01Modus(string modusPunkte)
        {
            while (true)
            {
                Console.WriteLine("-----" + modusPunkte + "-----");
                Console.WriteLine("Modus auswählen");
                Console.WriteLine("Single Out -->press SO");
                Console.WriteLine("Double Out -->press DO");
                Console.WriteLine("Master Out -->press MO");
                Console.WriteLine("Zurück zum X01 -->press exit");
                string modus = Console.ReadLine();

                if (modus == "SO")
                {
                    SX01(modusPunkte);
                }
                else if (modus == "DO")
                {

                    X01Doubleout(modusPunkte);

                }
                else if (modus == "MO")
                {
                    // Noch offen
                }
                else if (modus == "exit")
                {
                    return;
                }
                else
                {
                    starting.InvalidValue();
                }
            }

        }

        public void SX01(string modusPunkte)
        {
            
            int punktestand = 0;
            int runde = 1;
            int[] wuerfe = new int[3];

            string[] wuerfeString = { "1", "2", "3" };

            Console.WriteLine("-----" + modusPunkte + " Single Out-----");
            
            punktestand = Convert.ToInt32(modusPunkte);

            while (punktestand != 0 )
            {
                Console.WriteLine("Runde " + runde);

                for (wurf = 0; wurf <= 2; wurf++)
                {

                    Console.WriteLine(wuerfeString[wurf] + ".Pfeil -->Punkte eingeben");
                    eingabewuerfe[wurf] = Console.ReadLine();
                    Console.WriteLine(eingabewuerfe[wurf]);

                    //Überprüfung  reset, exit

                    if (eingabewuerfe[wurf] == "reset") // ---> Muss noch gemacht werden !!!!
                    {

                        Console.Clear();
                        SX01(modusPunkte);
                        return;
                    }
                    else if (eingabewuerfe[wurf] == "exit")
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        wuerfe[wurf] = starting.ÜberprüfungDatentyp(eingabewuerfe[wurf]);
                        wuerfe[wurf] = starting.ÜberprüfungMax_Min(wuerfe[wurf], eingabewuerfe[wurf]);

                        if ((punktestand - wuerfe[wurf]) < 0)
                        {
                            starting.InvalidValue();
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
                }
                runde++;

            }

            eingabeX01 = starting.GameFinished("X01", eingabeX01);

            if (eingabeX01 == "exit") //--> passt
            {
                Console.Clear();
                return;

            }
            else if (eingabeX01 == "reset") //--> passt
            {
                Console.Clear();
                SX01(modusPunkte);
                return;
            }
            else
            {
                starting.InvalidValue(); //--> passt
                starting.GameFinished("X01", eingabeX01);
            }
        }

        public void X01Doubleout(string modusPunkte)
        {
            int punktestand = 0;
            int wurf;

            int runde = 1;
            int[] wuerfe = new int[3];
            string[] eingabewuerfe = new string[3];
            string[] wuerfeString = { "1", "2", "3" };

            Console.WriteLine("-----" + modusPunkte + " Double Out-----");

            punktestand = Convert.ToInt32(modusPunkte);

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
                        Console.Clear();
                        X01Doubleout(eingabeX01);
                    }
                    if (eingabewuerfe[wurf] == "exit")
                    {
                        Console.Clear();
                        return;
                    }

                    wuerfe[wurf] = starting.ÜberprüfungDatentyp(eingabewuerfe[wurf]);
                    wuerfe[wurf] = starting.ÜberprüfungMax_Min(wuerfe[wurf], eingabewuerfe[wurf]);

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

            eingabeX01 = starting.GameFinished("X01", eingabeX01);

            if (eingabeX01 == "exit") //--> passt
            {
                Console.Clear();
                return;

            }
            else if (eingabeX01 == "reset") //--> passt
            {
                Console.Clear();
                X01Doubleout(modusPunkte);
                return;
            }
            else
            {
                starting.InvalidValue(); //--> passt
                starting.GameFinished("X01", eingabeX01);
            }

        }

    }
}



