using System;

namespace ChessConsole
{
    public class Program
    {
        static ChessGame game;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            ConsoleGraphics graphics = new ConsoleGraphics();
            bool invalid = true;
            int num = 0;

            while(invalid)
            {
                Console.WriteLine("1.) Chess");
                Console.WriteLine("2.) Chess 960");
                Console.Write("Choose your mode: ");
                string input = Console.ReadLine();

                try
                {
                    num = Int32.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid int.");
                }

                if (num > 0 && num < 3)
                {
                    invalid = false;
                }
                else
                {
                    Console.WriteLine("Invalid int.");
                }
            }
            
            if(num == 1)
            {
                game = new ChessGame(num);
                do
                {
                    game.Draw(graphics);
                    graphics.SwapBuffers();
                    game.Update();
                } while (game.Running);
                Console.Read();
            } else if(num == 2)
            {
                game = new ChessGame(num);
                do
                {
                    game.Draw(graphics);
                    graphics.SwapBuffers();
                    game.Update();
                } while (game.Running);
                Console.Read();
            }
        }
    }
}
