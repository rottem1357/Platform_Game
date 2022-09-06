/// <file>
/// Authors: Rotem Dresler . ID: 209207398. 
///          Izhak keidar . ID: 066016155.
///          
/// Date:    07/09/2022.
/// </file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class MyCharacterDesign:GameObject
    {
        public Head MyHead { get; set; }
        public Body MyBody { get; set; }
        public Leg MyLegLeft { get; set; }
        public Leg MyLegRight { get; set; }
        public Arm MyArmLeft { get; set; }
        public Arm MyArmRight { get; set; }
        public GameObject MyCharacter { get; set; }
        public Brush MyBrush { get; set; }
        public MyCharacterDesign(GameObject aCharacter, Color aColor)
        {
            MyCharacter = aCharacter;
            MyHead = new Head(MyCharacter , Brushes.LightSalmon);
            MyBody = new Body(MyHead , new SolidBrush(aColor));
            MyLegLeft = new Leg(MyBody, true , Brushes.Black);
            MyLegRight = new Leg(MyBody, false , Brushes.Black);
            MyArmLeft = new Arm(MyBody, true , Brushes.LightSalmon);  
            MyArmRight = new Arm(MyBody, false , Brushes.LightSalmon);
            MyBrush = new SolidBrush(aColor);
        }
        public override void Draw(Graphics canvas)
        {
            MyHead.Draw(canvas);
            MyBody.Draw(canvas);
            MyLegRight.Draw(canvas);
            MyLegLeft.Draw(canvas);
            MyArmLeft.Draw(canvas);
            MyArmRight.Draw(canvas);
        }
        public override void Move()
        {
            MyHead.Move();
            MyBody.Move();
            MyLegLeft.Move();
            MyLegRight.Move();
            MyArmRight.Move();
            MyArmLeft.Move();
        }
    }
}
