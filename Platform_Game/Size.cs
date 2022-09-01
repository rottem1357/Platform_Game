using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Size()
        {
            Width = 0;
            Height = 0;
        }
        public Size(int aWidth, int aHeight)
        {
            Width = aWidth;
            Height = aHeight;
        }
        public Size(Size a)
        { 
            this.Width = a.Width;   
            this.Height = a.Height; 
        }

        public int GetMaxRadiusInside()
        {
            return Math.Min(this.Width, this.Height);
        }
    }
}
