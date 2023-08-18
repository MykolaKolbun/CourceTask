using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Models
{
    public class Point
    {
        private int _left;
        private int _top;
        private ConsoleColor _color;
        private char _sign;

        public Point(int left, int top, ConsoleColor color, char sign)
        {
            Left = left;
            Top = top;
            Color = color;
            Sign = sign;
        }

        public char Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }


        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Left
        {
            get{return _left;}
            set{_left = value;}
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public void Draw()
        {
            Console.SetCursorPosition(this._left, this._top);
            Console.BackgroundColor = this._color;
            Console.Write(this._sign);
            Console.ResetColor();
        }

        public void Clear()
        {
            Console.SetCursorPosition(this._left, this._top);
            Console.Write(' ');
        }
    }
}
