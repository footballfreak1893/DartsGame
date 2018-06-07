using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Starting
    {
        private static GameX01 spiele = new GameX01();
        private static GameCricket cricket = new GameCricket();
        private static GameShanghai shanghai = new GameShanghai();
        private static Games.GameHighscore highscore = new Games.GameHighscore();
        private static Games.GameScoring scoring = new Games.GameScoring();
        private static Starting starting = new Starting();

        static void Main(string[] args)
        {
            Start();
        }
        static public void Start()
        {


            while (true)
            {
                Console.WriteLine("-----Dartsprogramm-----");
                Console.WriteLine("Kategorie auswählen");
                Console.WriteLine("X01 -->press X01");
                Console.WriteLine("Shanghai -->press SHA");
                Console.WriteLine("Highscore -->press HI");
                Console.WriteLine("Highscore -->press SCO");
                // Console.WriteLine("Cricket -->press CRI");
                string eingabekategorie = Console.ReadLine();
                Console.Clear();

                if (eingabekategorie == "X01")
                {
                    spiele.X01();
                }
                else if (eingabekategorie == "SHA")
                {
                    shanghai.SHA();
                }
                else if (eingabekategorie == "HI")
                {
                    highscore.High();
                }
                else if (eingabekategorie == "SCO")
                {
                    scoring.TrainingZahl();
                }
                else
                {
                    starting.InvalidValue();
                }
            }

        }

        public int ÜberprüfungDatentyp(string eingabewuerfe)
        {
            int punkte = 0;

            bool CanConvert = false;

            while (!CanConvert)
            {
                try
                {
                    punkte = Convert.ToInt32(eingabewuerfe);
                    CanConvert = true;
                    break;

                }
                catch
                {
                    Console.WriteLine("Ungültiger Wert: --> Ganze Zahl eingeben");
                }
                eingabewuerfe = Console.ReadLine();
            }
            return punkte;
        }

        public int ÜberprüfungMax_Min(int wuerfe, string eingabewuerfe)
        {
            while (wuerfe > 60 || wuerfe < 0)
            {
                InvalidValue();
                Console.WriteLine("MAX/MIN");
                Console.WriteLine("Punkezahl eingeben");
                eingabewuerfe = Console.ReadLine();
                wuerfe = ÜberprüfungDatentyp(eingabewuerfe);
            }
            return wuerfe;
        }

        public void InvalidValue()
        {
            Console.WriteLine("Ungültiger Wert");
        }

        public void FunktioniertTest()
        {
            Console.WriteLine("Funktioniert bisher");
        }

        public string GameFinished(string gameMenu, string eingabeX01)
        {
                Console.WriteLine("Spiel beendet");
                Console.WriteLine("Spiel erneut starten -->press: reset");
                Console.WriteLine("Zurück zum Menü " + gameMenu + " -->press exit");
                 eingabeX01 = Console.ReadLine();
                Console.Clear();
            Console.WriteLine("XD");

            return eingabeX01;

            }
        }
    }




