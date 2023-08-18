using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Models
{
    public class Brick
    {
        public int Color { get; set; }
        public int Weight { get; set; }
        public List<Point> brick { get; set; }
        public Brick(int len, int weight, int color)
        {
            brick = new List<Point>();
            for (int i = 0; i < len; i++)
            {
                brick.Add(new Point());
            }
        }
    }
}
