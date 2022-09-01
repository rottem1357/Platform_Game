using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Monster : Entity
    {
        public Image myDesign;
        public int MySerialCode;
        public int ActionInterval;

        public Monster(string aNickName, Size aSize, Location aLocation) : base(aNickName,aSize, aLocation)
        {
            Random random = new Random();
            MySerialCode = random.Next(1,4);
            myDesign = Image.FromFile("C:\\Users\\rotte\\OneDrive\\rottem\\dev\\Platform_Game\\images\\" + MySerialCode + ".jpg");
            this.ActionInterval = 0;
        }
        public override void Draw(Graphics canvas)
        {
            canvas.DrawImage(myDesign, this.Location.Col, this.Location.Row, this.Size.Width, this.Size.Height);
            this.DrawEntityLevel(canvas);
            this.DrawHPBar(canvas);
        }

        public override void Move()
        {
            Random rand = new Random();
            int k = rand.Next(0, 60);


            if (this.ActionInterval == 0)
            {
                switch(k % 3)
                {
                    case 0:
                        this.IsGoingLeft = true;
                        break;
                    case 1:
                        this.IsGoingRight = true;
                        break;
                    case 2:
                        this.Jump();
                        break;
                }
                this.ActionInterval++;
            }
            else
            {
                this.ActionInterval++;
                if (this.ActionInterval >= 20)
                {
                    this.ActionInterval = 0;
                    this.IsGoingLeft = false;
                    this.IsGoingRight = false;  
                }
                    
            }
            this.MoveEntity();
        }
    }
}
