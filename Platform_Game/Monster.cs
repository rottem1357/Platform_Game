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

        public Monster(string aNickName, Size aSize, Location aLocation) : base(aNickName,aSize, aLocation)
        {
            Random random = new Random();
            MySerialCode = random.Next(3);
            myDesign = Image.FromFile("C:\\Users\\rotte\\OneDrive\\rottem\\dev\\Platform_Game\\images\\Monster");
        }
        public override void Draw(Graphics canvas)
        {
            canvas.DrawImage(myDesign, this.Location.Col, this.Location.Row, this.Size.Width, this.Size.Height);   
        }

        public override void Move()
        {

        }
    }
}
