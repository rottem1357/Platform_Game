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
    internal class Platform:GameObject
    {
        public Brush MyBrush1 { get; set; }
        public Brush MyBrush2 { get; set; }

        public Platform(Size aSize, Location aLocation) : base(aSize, aLocation)
        { 
            MyBrush1 = Brushes.Brown;
            MyBrush2 = Brushes.Green;
        }

        public Platform(Brush b1 , Brush b2, Size aSize, Location aLocation) : base(aSize, aLocation)
        {
            MyBrush1 = b1;
            MyBrush2 = b2;
        }
        public override void Draw(Graphics canvas)
        {
            canvas.FillRectangle(MyBrush1, this.Location.Col, this.Location.Row, this.Size.Width, this.Size.Height);
            canvas.FillRectangle(MyBrush2, this.Location.Col, this.Location.Row, this.Size.Width, this.Size.Height / 6);
            canvas.DrawRectangle(Pens.Black, this.Location.Col, this.Location.Row, this.Size.Width, this.Size.Height);
        }

        // there are no moving platforms at this game.
        public override void Move()
        {

        }
    }
}
