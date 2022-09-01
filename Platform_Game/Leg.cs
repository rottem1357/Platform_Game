using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Leg : GameObject
    {
        public Body MyBody { get; set; }
        public bool IsLeft { get; set; }

        public Brush MyColor { get; set; }

        public Leg(Body aBody , bool aIsLeft , Brush c) : base()
        {
            this.MyBody = aBody;
            this.Size.Width = 2;
            this.Size.Height = MyBody.Size.Height;
            IsLeft = aIsLeft;
            if (IsLeft)
                this.Location.Col = MyBody.Location.Col;
            else
                this.Location.Col = MyBody.Location.Col + MyBody.Size.Width - this.Size.Width;
            this.Location.Row = MyBody.Location.Row + MyBody.Size.Height;
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
            if (IsLeft)
                this.Location.Col = MyBody.Location.Col;
            else
                this.Location.Col = MyBody.Location.Col + MyBody.Size.Width - this.Size.Width;
            this.Location.Row = MyBody.Location.Row + MyBody.Size.Height;
        }
    }
}
