using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Models
{
    public class Platform
    {
        readonly List<Point> points;
        public Platform(Point basePoint, int length)
        {
            points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                points.Add(new Point(basePoint.Left+i, basePoint.Top, basePoint.Color, basePoint.Sign));
            }
            this.Draw();
        }

        void Draw()
        {
            foreach (var point in points) 
            {
                point.Draw();
            }
        }

        public void MoveRight()
        {
            points.First().Clear();
            foreach (var point in points)
            {
                point.Left++;
            }
            this.Draw();
        }

        public void MoveLeft()
        {
            points.Last().Clear();
            foreach (var point in points)
            {
                point.Left--;
            }
            this.Draw();
        }
    }
}
