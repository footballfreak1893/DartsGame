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
                    return;
                }

                else
                {
                    SX01(eingabeX01);// beachten
                }
            }
        }

        public void SX01(string eingabeX01)
        {
            int punkte=0;
            Console.WriteLine("-----" + eingabeX01 + "-----");
            int punktestand;
            punktestand = Convert.ToInt32(eingabeX01);

            while (punktestand -punkte !=0 )
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
                int ipunktestand = punktestand;
                //punktestand = punktestand - punkte;
                if ((ipunktestand = ipunktestand - punkte) <0)
                {
                    Console.WriteLine("Ungültiger Wert");
                    punktestand = punktestand - 0;
                }
                punktestand = punktestand - punkte;
               
                Console.WriteLine("p" + punktestand);
               
                
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
    }
}
