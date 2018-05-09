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

        static void Main(string[] args)
        {
            Start();
        }
        static public void Start()
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

            while (true)
            {
                if (eingabekategorie != "X01" && eingabekategorie != "SHA" && eingabekategorie != "CRI" && eingabekategorie !="HI" && eingabekategorie != "SCO")
                {
                    Console.WriteLine("Ungültiger Wert");
                    Console.WriteLine("Kategorie auswählen");
                    Console.WriteLine("X01 -->press X01");
                    Console.WriteLine("Shanghai -->press SHA");
                    Console.WriteLine("Cricket -->press CRI");
                    Console.WriteLine("Highscore -->press HI");
                    Console.WriteLine("Highscore -->press SCO");
                    eingabekategorie = Console.ReadLine();
                    Console.Clear();
                }
                else if (eingabekategorie == "X01")
                {
                    spiele.X01();
                    Start();
                    return;
                    
                }
                else if (eingabekategorie == "SHA")
                {
                    shanghai.SHA();
                    Start();
                    return;
                }
                else if (eingabekategorie == "HI")
                {
                    highscore.High();
                    Start();
                    return;
                }
                else if (eingabekategorie == "SCO")
                {
                    scoring.TrainingZahl();
                    Start();
                    return;
                }
                else
                {
                    cricket.CricketGame();
                    
                }
            }

        }

    }
}



