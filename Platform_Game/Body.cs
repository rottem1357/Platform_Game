using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Body : GameObject
    {
        public Head MyHead {get; set;}
        public Brush MyColor { get; set; }

        public Body(Head aHead, Brush c) : base()
        { 
            this.MyHead = aHead;
            this.Size.Width = MyHead.Size.Width / 3;
            this.Size.Height = MyHead.Size.Height;
            this.Location.Col = MyHead.Location.Col + (MyHead.Size.Width / 2) - (this.Size.Width / 2);
            this.Location.Row = MyHead.Location.Row + MyHead.Size.Height;
            MyColor = c;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.FillRectangle(MyColor,
                this.Location.Col,
                this.Location.Row,
                this.Size.Width,
                this.Size.Height);
        }

        public override void Move()
        {
            this.Location.Col = MyHead.Location.Col + (MyHead.Size.Width / 2) - (this.Size.Width / 2);
            this.Location.Row = MyHead.Location.Row + MyHead.Size.Height;
        }
    }
}
