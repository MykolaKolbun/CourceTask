using Arkanoid.Models;

namespace Arkanoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 60);
            Console.SetBufferSize(120, 60); 

            Screen screen = new(100, 30);
            screen.Draw();

            Platform platform = new(new Point(2, 26, ConsoleColor.Black, '#'), 3);
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if(key.Key == ConsoleKey.RightArrow)
                    {
                        platform.MoveRight();
                    }
                    else if(key.Key == ConsoleKey.LeftArrow) 
                    { 
                        platform.MoveLeft(); 
                    }
                }
                Thread.Sleep(10);
            }
        }
    }
}