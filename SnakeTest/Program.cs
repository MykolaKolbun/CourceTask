namespace SnakeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for(int i = 0; i<20; i++)
            {
                Point point = new(i, 2, '0');
                Point.Draw(point);
                Thread.Sleep(100);
            }
        }
    }
}