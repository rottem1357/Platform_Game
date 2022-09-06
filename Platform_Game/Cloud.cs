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
    internal class Cloud : GameObject
    {
        private List<Circle> mParts;
        public Cloud(Size aSize, Location aLocation) : base(aSize , aLocation)
        {
            mParts = new List<Circle>();
        }

        public Cloud(int aCount,Size aSize, Location aLocation) : base(aSize, aLocation)
        {
            Circle c;
            mParts = new List<Circle>();
            int x, y, r;
            
            for (int index = 0; index < aCount; index++)
            {
                r = MyRandom.Next(2 * (aSize.GetMaxRadiusInside() / 3), 3 * (aSize.GetMaxRadiusInside() / 4));
                switch (index)
                {
                    case 0:
                        x = 0;
                        y = MyRandom.Next(0, aSize.Height - r);
                        break;
                    case 1:
                        y = 0;
                        x = MyRandom.Next(0, aSize.Width - r);
                        break;
                    case 2:
                        x = aSize.Width - r;
                        y = MyRandom.Next(0, aSize.Height - r);
                        break;
                    case 3:
                        y = aSize.Height - r;
                        x = MyRandom.Next(0, aSize.Width - r);
                        break;
                    default:
                        x = MyRandom.Next(0, aSize.Width - r);
                        y = MyRandom.Next(0, aSize.Height - r);
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
