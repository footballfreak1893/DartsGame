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
            
            

            
            bool CanConvert = false;

                while (!CanConvert)
                {
                    try
                    {
                        spiele.wurf = Convert.ToInt32(eingabewuerfe);
                        CanConvert =true;
                        break;

                    }
                    catch
                    {
                        Console.WriteLine("Ungültiger Wert: --> Ganze Zahl eingeben");
                    }
                    eingabewuerfe[spiele.wurf] = Console.ReadLine();
                }
            return wurf;
        }
        public void InvalidValue()
        {
            Console.WriteLine("Ungültiger Wert");
        }

    }
}



