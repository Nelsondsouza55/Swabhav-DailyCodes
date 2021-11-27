using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame
{
    public static class Global
    {
        public static int turns;
        public static int score;

    }
    class Program
    {   
        public static void Main()
        {
            Console.WriteLine("Welcome to the PIG game");
            Global.turns = 1;
            WelcomeToTheGame();
            Console.ReadKey();

        }
        static void WelcomeToTheGame()
        {
            
            
            Console.WriteLine("TURN " + Global.turns);
            Console.WriteLine("Roll or Hold? (r/h) ");
            int roh = ConvertTo.Int32(Console.ReadLine());

            switch (roh)
            {
                case 1:
                    GameStart();
                    break;

                case 2:
                    StatusGame();
                    break;
            }
        }

        static void GameStart()
        {

            Random rnd = new Random();
            int Rnum = rnd.Next(1, 7);
            Console.WriteLine("Die: " + Rnum);

            if (Rnum == 1)
            {
                Console.WriteLine("Turn Over No score");
                Console.WriteLine("");
                Global.score = 0;
                Global.turns = Global.turns+ 1;
                WelcomeToTheGame();
            }
            else
            {
                Global.score = Global.score + Rnum;
                Console.WriteLine("Your score is " + Global.score);
                WinCheck();
                WelcomeToTheGame();
            }

                
        }

        static void StatusGame()
        {
            Console.WriteLine("Your Status of the game is:");
            Console.WriteLine("The score is: " +Global.score);
            Global.turns = Global.turns + 1;
            WelcomeToTheGame();
        }


        static void WinCheck()
        {
            if (Global.score > 20)
            {
                Console.WriteLine("Congratulations you win");
                Console.WriteLine("You took " + Global.turns+ " turns to finish");
                Console.WriteLine("GAME OVER!");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}

