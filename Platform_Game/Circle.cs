/// <file>
/// Authors: Rotem Dresler . ID: 209207398. 
///          Izhak keidar . ID: 066016155.
///          
/// Date:    07/09/2022.
/// </file>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }

        public Circle()
        {
            // this function is resetting the X and Y to 0
            X = 0;
            Y = 0;
            R = 0;
        }

        public Circle(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }

        public void Draw(Graphics canvas, Brush brush)
        {
            canvas.FillEllipse(brush, this.X,
                  this.Y, this.R, this.R);
        }

        public void Draw(Graphics canvas, Pen pen)
        {
            canvas.DrawEllipse(pen, this.X,
                     this.Y, this.R, this.R);
        }
    }
}
