using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeTest
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sign { get; set; }

        public Point(int x, int y, char sign)
        {
            X=x; 
            Y=y; 
            Sign=sign;
        }

        public static void Draw(Point point)
        {
            //Console.Clear();
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write(point.Sign);
        }
    }
}
