using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameCricket
    {
       
        
        public void CricketGame()
        {
            //vars
            int punktestand = 0;
            int wurf1 = 0;
            int wurf2 = 0;
            int wurf3 = 0;
            string eingabewurf1;
            string eingabewurf2;
            string eingabewurf3;
            int runde = 0;
            int[] treffer = new int[7];
            int eingabe1;
            int eingabe2;
            int eingabe3;

            //Cricket Zahlen
            // n --> number
            //int[] n15 = new int[] { 15, 30, 45 };
            //int[] n16 = new int[] { 16, 32, 48 };
            //int[] n17 = new int[] { 17, 34, 51 };
            //int[] n18 = new int[] { 18, 36, 54 };
            //int[] n19 = new int[] { 19, 38, 57 };
            //int[] n20 = new int[] { 20, 40, 60 };
            //int[] nbull = new int[] { 25, 50};
            int treffer15 = 0, treffer16 = 0, treffer17 = 0, treffer18 = 0, treffer19 = 0, treffer20 = 0, trefferbull = 0;

            Console.WriteLine("-----Cricket-----");
            while (treffer15 <= 3 && treffer16 <= 3 && treffer17 <= 3 && treffer18 <= 3 && treffer19 <= 3 && treffer20 <= 3 && trefferbull <= 3)
            {
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
                while (
                    wurf1 != 15 * 1 && wurf1 != 15 * 2 && wurf1 != 15 * 3 &&
                    wurf1 != 16 * 1 && wurf1 != 16 * 2 && wurf1 != 16 * 3 &&
                    wurf1 != 17 * 1 && wurf1 != 17 * 2 && wurf1 != 17 * 3 &&
                    wurf1 != 18 * 1 && wurf1 != 18 * 2 && wurf1 != 18 * 3 &&
                    wurf1 != 19 * 1 && wurf1 != 19 * 2 && wurf1 != 19 * 3 &&
                    wurf1 != 20 * 1 && wurf1 != 20 * 2 && wurf1 != 20 * 3 &&
                    wurf1 != 25 * 1 && wurf1 != 25 * 2 && wurf1 != 0
                    )
                {
                    Console.WriteLine("Ungültige Zahl");
                    eingabewurf1 = Console.ReadLine();

                    canConvert = int.TryParse(eingabewurf1, out wurf1);

                    while (canConvert == false)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabewurf1 = Console.ReadLine();
                        canConvert = int.TryParse(eingabewurf1, out wurf1);
                    }
                   // Cricket überprüfen eingabe1 = treffer[] - 15;
                }
                switch (eingabewurf1)
                {
                    case "15":
                        // punktestand = punktestand + 15;
                        treffer15 = treffer15 + 1;
                        break;

                    case "30":
                        //punktestand = punktestand + 30;
                        treffer15 = treffer15 + 2;
                        break;

                    case "45":
                        //punktestand = punktestand + 45;
                        treffer15 = treffer15 + 3;
                        break;

                    case "16":
                        //punktestand = punktestand + 16;
                        treffer16 = treffer16 + 1;
                        break;

                    case "32":
                        //punktestand = punktestand + 32;
                        treffer16 = treffer16 + 2;
                        break;

                    case "48":
                        //punktestand = punktestand + 48;
                        treffer16 = treffer16 + 3;
                        break;

                    case "17":
                        //punktestand = punktestand + 17;
                        treffer17 = treffer17 + 1;
                        break;

                    case "34":
                        //punktestand = punktestand + 34;
                        treffer17 = treffer17 + 2;
                        break;

                    case "51":
                        //punktestand = punktestand + 51;
                        treffer17 = treffer17 + 3;
                        break;

                    case "18":
                        //punktestand = punktestand + 18;
                        treffer18 = treffer18 + 1;
                        break;

                    case "36":
                        //punktestand = punktestand + 36;
                        treffer18 = treffer18 + 2;
                        break;

                    case "54":
                        //punktestand = punktestand + 54;
                        treffer18 = treffer18 + 3;
                        break;

                    case "19":
                        //punktestand = punktestand + 19;
                        treffer19 = treffer19 + 1;
                        break;

                    case "38":
                        //punktestand = punktestand + 38;
                        treffer19 = treffer19 + 2;
                        break;

                    case "57":
                        //punktestand = punktestand + 57;
                        treffer19 = treffer19 + 3;
                        break;

                    case "20":
                        //punktestand = punktestand + 20;
                        treffer20 = treffer20 + 1;
                        break;

                    case "40":
                        //punktestand = punktestand + 40;
                        treffer20 = treffer20 + 2;
                        break;

                    case "60":
                        //punktestand = punktestand + 60;
                        treffer20 = treffer20 + 3;
                        break;

                    case "25":
                        //punktestand = punktestand + 25;
                        trefferbull = trefferbull + 1;
                        break;

                    case "50":
                        //punktestand = punktestand + 50;
                        trefferbull = trefferbull + 2;
                        break;

                    default:
                    case "0":
                        punktestand = punktestand + 0;
                        break;
                }
                if (treffer15 == 3 && treffer16 == 3 && treffer17 == 3 && treffer18 == 3 && treffer19 == 3 && treffer20 == 3 && trefferbull == 3)
                {
                    break;
                }
                if (treffer15 == 3 || treffer16 == 3 || treffer17 == 3 || treffer18 == 3 || treffer19 == 3 || treffer20 == 3 || trefferbull == 3)
                {

                }
                Console.WriteLine("2. Pfeil -->Punkte eingeben");
                eingabewurf2 = Console.ReadLine();

                //Überprüfung 2 reset, exit
                if (eingabewurf1 == "reset")
                {
                    return;
                }
                if (eingabewurf1 == "exit")
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

                while (
                    wurf2 != 15 * 1 && wurf2 != 15 * 2 && wurf2 != 15 * 3 &&
                    wurf2 != 16 * 1 && wurf2 != 16 * 2 && wurf2 != 16 * 3 &&
                    wurf2 != 17 * 1 && wurf2 != 17 * 2 && wurf2 != 17 * 3 &&
                    wurf2 != 18 * 1 && wurf2 != 18 * 2 && wurf2 != 18 * 3 &&
                    wurf2 != 19 * 1 && wurf2 != 19 * 2 && wurf2 != 19 * 3 &&
                    wurf2 != 20 * 1 && wurf2 != 20 * 2 && wurf2 != 20 * 3 &&
                    wurf2 != 25 * 1 && wurf2 != 25 * 2 && wurf2 != 0
                    )
                {
                    Console.WriteLine("Ungültige Zahl");
                    eingabewurf2 = Console.ReadLine();

                    canConvert = int.TryParse(eingabewurf2, out wurf2);

                    while (canConvert == false)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabewurf2 = Console.ReadLine();
                        canConvert = int.TryParse(eingabewurf2, out wurf2);
                    }

                }
                switch (eingabewurf2)
                {
                    case "15":
                        // punktestand = punktestand + 15;
                        treffer15 = treffer15 + 1;
                        break;

                    case "30":
                        //punktestand = punktestand + 30;
                        treffer15 = treffer15 + 2;
                        break;

                    case "45":
                        //punktestand = punktestand + 45;
                        treffer15 = treffer15 + 3;
                        break;

                    case "16":
                        //punktestand = punktestand + 16;
                        treffer16 = treffer16 + 1;
                        break;

                    case "32":
                        //punktestand = punktestand + 32;
                        treffer16 = treffer16 + 2;
                        break;

                    case "48":
                        //punktestand = punktestand + 48;
                        treffer16 = treffer16 + 3;
                        break;

                    case "17":
                        //punktestand = punktestand + 17;
                        treffer17 = treffer17 + 1;
                        break;

                    case "34":
                        //punktestand = punktestand + 34;
                        treffer17 = treffer17 + 2;
                        break;

                    case "51":
                        //punktestand = punktestand + 51;
                        treffer17 = treffer17 + 3;
                        break;

                    case "18":
                        //punktestand = punktestand + 18;
                        treffer18 = treffer18 + 1;
                        break;

                    case "36":
                        //punktestand = punktestand + 36;
                        treffer18 = treffer18 + 2;
                        break;

                    case "54":
                        //punktestand = punktestand + 54;
                        treffer18 = treffer18 + 3;
                        break;

                    case "19":
                        //punktestand = punktestand + 19;
                        treffer19 = treffer19 + 1;
                        break;

                    case "38":
                        //punktestand = punktestand + 38;
                        treffer19 = treffer19 + 2;
                        break;

                    case "57":
                        //punktestand = punktestand + 57;
                        treffer19 = treffer19 + 3;
                        break;

                    case "20":
                        //punktestand = punktestand + 20;
                        treffer20 = treffer20 + 1;
                        break;

                    case "40":
                        //punktestand = punktestand + 40;
                        treffer20 = treffer20 + 2;
                        break;

                    case "60":
                        //punktestand = punktestand + 60;
                        treffer20 = treffer20 + 3;
                        break;

                    case "25":
                        //punktestand = punktestand + 25;
                        trefferbull = trefferbull + 1;
                        break;

                    case "50":
                        //punktestand = punktestand + 50;
                        trefferbull = trefferbull + 2;
                        break;

                    default:
                    case "0":
                        punktestand = punktestand + 0;
                        break;
                }
                if (treffer15 == 3 && treffer16 == 3 && treffer17 == 3 && treffer18 == 3 && treffer19 == 3 && treffer20 == 3 && trefferbull == 3)
                {
                    break;
                }


                Console.WriteLine("3. Pfeil -->Punkte eingeben");
                eingabewurf3 = Console.ReadLine();

                //Überprüfung 3 reset, exit
                if (eingabewurf1 == "reset")
                {
                    return;
                }
                if (eingabewurf1 == "exit")
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

                while (
                    wurf3 != 15 * 1 && wurf3 != 15 * 2 && wurf3 != 15 * 3 &&
                    wurf3 != 16 * 1 && wurf3 != 16 * 2 && wurf3 != 16 * 3 &&
                    wurf3 != 17 * 1 && wurf3 != 17 * 2 && wurf3 != 17 * 3 &&
                    wurf3 != 18 * 1 && wurf3 != 18 * 2 && wurf3 != 18 * 3 &&
                    wurf3 != 19 * 1 && wurf3 != 19 * 2 && wurf3 != 19 * 3 &&
                    wurf3 != 20 * 1 && wurf3 != 20 * 2 && wurf3 != 20 * 3 &&
                    wurf3 != 25 * 1 && wurf3 != 25 * 2 && wurf3 != 0
                    )
                {
                    Console.WriteLine("Ungültige Zahl");
                    eingabewurf3 = Console.ReadLine();

                    canConvert = int.TryParse(eingabewurf3, out wurf3);

                    while (canConvert == false)
                    {
                        Console.WriteLine("Ungültiger Wert");
                        Console.WriteLine("Punkezahl eingeben");
                        eingabewurf3 = Console.ReadLine();
                        canConvert = int.TryParse(eingabewurf1, out wurf3);
                    }

                }
                switch (eingabewurf3)
                {
                    case "15":
                        // punktestand = punktestand + 15;
                        treffer15 = treffer15 + 1;
                        break;

                    case "30":
                        //punktestand = punktestand + 30;
                        treffer15 = treffer15 + 2;
                        break;

                    case "45":
                        //punktestand = punktestand + 45;
                        treffer15 = treffer15 + 3;
                        break;

                    case "16":
                        //punktestand = punktestand + 16;
                        treffer16 = treffer16 + 1;
                        break;

                    case "32":
                        //punktestand = punktestand + 32;
                        treffer16 = treffer16 + 2;
                        break;

                    case "48":
                        //punktestand = punktestand + 48;
                        treffer16 = treffer16 + 3;
                        break;

                    case "17":
                        //punktestand = punktestand + 17;
                        treffer17 = treffer17 + 1;
                        break;

                    case "34":
                        //punktestand = punktestand + 34;
                        treffer17 = treffer17 + 2;
                        break;

                    case "51":
                        //punktestand = punktestand + 51;
                        treffer17 = treffer17 + 3;
                        break;

                    case "18":
                        //punktestand = punktestand + 18;
                        treffer18 = treffer18 + 1;
                        break;

                    case "36":
                        //punktestand = punktestand + 36;
                        treffer18 = treffer18 + 2;
                        break;

                    case "54":
                        //punktestand = punktestand + 54;
                        treffer18 = treffer18 + 3;
                        break;

                    case "19":
                        //punktestand = punktestand + 19;
                        treffer19 = treffer19 + 1;
                        break;

                    case "38":
                        //punktestand = punktestand + 38;
                        treffer19 = treffer19 + 2;
                        break;

                    case "57":
                        //punktestand = punktestand + 57;
                        treffer19 = treffer19 + 3;
                        break;

                    case "20":
                        //punktestand = punktestand + 20;
                        treffer20 = treffer20 + 1;
                        break;

                    case "40":
                        //punktestand = punktestand + 40;
                        treffer20 = treffer20 + 2;
                        break;

                    case "60":
                        //punktestand = punktestand + 60;
                        treffer20 = treffer20 + 3;
                        break;

                    case "25":
                        //punktestand = punktestand + 25;
                        trefferbull = trefferbull + 1;
                        break;

                    case "50":
                        //punktestand = punktestand + 50;
                        trefferbull = trefferbull + 2;
                        break;

                    default:
                    case "0":
                        punktestand = punktestand + 0;
                        break;
                }
                if (treffer15 == 3 && treffer16 == 3 && treffer17 == 3 && treffer18 == 3 && treffer19 == 3 && treffer20 == 3 && trefferbull == 3)
                {
                    break;
                }
                runde++;
                //Übersicht Runde + Treffer
                Console.WriteLine("Runde: " + runde);
                Console.WriteLine("Punkestand: " + punktestand);
                Console.WriteLine("15: --> " + treffer15);
                Console.WriteLine("16: --> " + treffer16);
                Console.WriteLine("17: --> " + treffer17);
                Console.WriteLine("18: --> " + treffer18);
                Console.WriteLine("19: --> " + treffer19);
                Console.WriteLine("20: --> " + treffer20);
                Console.WriteLine("Bull: --> " + trefferbull);
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
            //if (eingabemenu == "SHA")
            //{
            //    return;
            //}
            //else
            //{
            //    Starting.Start();
            //}
            //Console.ReadKey();



































































































































































































































































































































































































































































































































































































        }
    }
}
