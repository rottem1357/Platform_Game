using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Cloud : GameObject
    {
        private List<Circle> mParts;
        public Cloud(Size aSize, Location aLocation) : base(aSize , aLocation)
        {
            mParts = new List<Circle>();
        }

        public Cloud(int aCount,Size aSize, Location aLocation) : base(aSize, aLocation)
        {
            Random random = new Random();
            Circle c;
            mParts = new List<Circle>();
            int x, y, r;
            
            for (int index = 0; index < aCount; index++)
            {
                r = random.Next(2 * (aSize.GetMaxRadiusInside() / 3), 3 * (aSize.GetMaxRadiusInside() / 4));
                switch (index)
                {
                    case 0:
                        x = 0;
                        y = random.Next(0, aSize.Height - r);
                        break;
                    case 1:
                        y = 0;
                        x = random.Next(0, aSize.Width - r);
                        break;
                    case 2:
                        x = aSize.Width - r;
                        y = random.Next(0, aSize.Height - r);
                        break;
                    case 3:
                        y = aSize.Height - r;
                        x = random.Next(0, aSize.Width - r);
                        break;
                    default:
                        x = random.Next(0, aSize.Width - r);
                        y = random.Next(0, aSize.Height - r);
                        break;
                }
                c = new Circle(x,y,r);
                mParts.Add(c);
            }
        }

        public override void Move()
        {
            this.Location.Col += 4;
        }


        public override void Draw(Graphics canvas)
        { 

            foreach (Circle c in mParts)
            {
                canvas.DrawEllipse(Pens.Gray, this.Location.Col + c.X,
                    this.Location.Row + c.Y, c.R, c.R);
            }
            foreach (Circle c in mParts)
            {
                canvas.FillEllipse(Brushes.WhiteSmoke, this.Location.Col + c.X,
                  this.Location.Row + c.Y, c.R, c.R);
            }

        }
    }
}
