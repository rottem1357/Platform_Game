using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Head:GameObject
    {
        public Brush MyColor { get; set; }
        public GameObject MyCharacter { get; set; }

        public Eye MyEyeLeft { get; set; }
        public Eye MyEyeRight { get; set; }

        public Head(GameObject aCharacter, Brush c) : base()
        {
            MyCharacter = aCharacter;
            this.Location.Row = MyCharacter.Location.Row;
            this.Location.Col = MyCharacter.Location.Col;
            this.Size.Width = MyCharacter.Size.Width;
            this.Size.Height = MyCharacter.Size.Height / 3;
            MyColor = c;
            MyEyeLeft = new Eye(this, true);
            MyEyeRight = new Eye(this, false);
        }

        public override void Draw(Graphics canvas)
        {
            canvas.FillEllipse(MyColor,
                this.Location.Col,
                this.Location.Row,
                this.Size.Width,
                this.Size.Height);
            MyEyeLeft.Draw(canvas); 
            MyEyeRight.Draw(canvas);    
        }

        public override void Move()
        {
            this.Location.Row = MyCharacter.Location.Row;
            this.Location.Col = MyCharacter.Location.Col;
            MyEyeLeft.Move();
            MyEyeRight.Move();
        }

        public void UpdateFaceDirection(bool aIsFacingLeft)
        {
            this.MyEyeLeft.IsFacingLeft = aIsFacingLeft;
            this.MyEyeRight.IsFacingLeft = aIsFacingLeft; 
        }

    }
}
