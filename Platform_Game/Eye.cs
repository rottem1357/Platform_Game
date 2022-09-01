using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class Eye : GameObject
    {
        public Head MyHead { get; set; }
        public bool IsLeft { get; set; }

        public bool IsFacingLeft { get; set; }
        public Eye(Head aHead, bool aIsLeft) : base()
        { 
            this.MyHead = aHead;
            this.IsLeft = aIsLeft;
            this.Size.Width = this.MyHead.Size.Width / 4;
            this.Size.Height = this.MyHead.Size.Height / 4;
            if (IsLeft)
                this.Location.Col = this.MyHead.Location.Col + (2 * (this.MyHead.Size.Width / 5));
            else
                this.Location.Col = this.MyHead.Location.Col + (4 * (this.MyHead.Size.Width / 5));
            this.Location.Row = this.MyHead.Location.Row + (this.MyHead.Size.Height / 3);

            this.IsFacingLeft = false;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.FillEllipse(Brushes.White,
                this.Location.Col,
                this.Location.Row,
                this.Size.Width,
                this.Size.Height);

            canvas.FillEllipse(Brushes.Brown,
                this.Location.Col + (this.Size.Width / 2),
                this.Location.Row + (this.Size.Height / 2),
                this.Size.Width / 2,
                this.Size.Height / 2);
        }
        public override void Move()
        {
            if (this.IsFacingLeft)
            {
                if (IsLeft)
                    this.Location.Col = this.MyHead.Location.Col + (1 * (this.MyHead.Size.Width / 5));
                else
                    this.Location.Col = this.MyHead.Location.Col + (3 * (this.MyHead.Size.Width / 5));
                this.Location.Row = this.MyHead.Location.Row + (this.MyHead.Size.Height / 3);

            }
            else
            {
                if (IsLeft)
                    this.Location.Col = this.MyHead.Location.Col + (2 * (this.MyHead.Size.Width / 5));
                else
                    this.Location.Col = this.MyHead.Location.Col + (4 * (this.MyHead.Size.Width / 5));
                this.Location.Row = this.MyHead.Location.Row + (this.MyHead.Size.Height / 3);

            }

        }
    }
}
