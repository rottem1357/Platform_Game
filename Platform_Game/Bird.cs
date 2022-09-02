using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Bird : GameObject
    {
        public int mBase;
        public int mTop;
        private bool mUp;

        public Bird(Size aSize, Location aLocation) : base(aSize, aLocation)
        {
            mBase = aSize.Height;
            mTop = 0;
            mUp = true;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.DrawLine(Pens.Black , this.Location.Col,
                this.Location.Row + this.mTop,
                this.Location.Col + this.Size.Width / 2,
                this.Location.Row +mBase);
            canvas.DrawLine(Pens.Black, this.Location.Col + this.Size.Width / 2,
                this.Location.Row + mBase,
               this.Location.Col + this.Size.Width,
               this.Location.Row + mTop);
        }

        public override void Move()
        {
            int k;
            this.Location.Col += 4;
            if (mUp)
            {
                k = MyRandom.Next(Math.Max(mBase, mTop) / 2);
                if (this.mBase - k < 0)
                { 
                    this.mUp = false;
                    return;
                }
                k /= 2;
                this.mTop += k;
                this.mBase -= k;
            }
            else
            {
                k = MyRandom.Next(Math.Max(mBase, mTop));
                if (this.mTop - k < 0)
                {
                    this.mUp = true;
                    return;
                }
                k /= 2;
                this.mBase += k;
                this.mTop -= k;
            }
            k = MyRandom.Next(0 ,7);
            this.Location.Row += k - 3;

        }
    }
}
