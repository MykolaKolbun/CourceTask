using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Models
{
    internal class Screen
    {
        readonly List<Point> horizBorder;
        readonly List<Point> vertBorder;
        public Screen(int horizon, int vert) 
        {
            //Console.BufferWidth = horizon;
            //Console.BufferHeight = vert;
            horizBorder = new List<Point>();
            vertBorder = new List<Point>();
            for (int i = 0; i < horizon; i++)
            {
                horizBorder.Add(new Point(i, 0, ConsoleColor.Black, '-'));
                horizBorder.Add(new Point(i, vert, ConsoleColor.Black, '-'));
            }
            for (int i = 0; i < vert; i++)
            {
                vertBorder.Add(new Point(0, i, ConsoleColor.Black, '+'));
                vertBorder.Add(new Point(horizon, i, ConsoleColor.Black, '+'));
            }
        }

        public void Draw()
        {
            foreach (var point in horizBorder)
            {
                point.Draw();
            }
            foreach (var point in vertBorder)
            {
                point.Draw();
            }
        }
    }
}
