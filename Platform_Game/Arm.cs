﻿/// <file>
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
    internal class Arm : GameObject
    {
        public Body MyBody { get; set; }
        private bool IsLeft { get; set; }
        private Brush MyColor { get; set; }

        public Arm(Body aBody, bool aIsLeft, Brush c) : base()
        {
            this.MyBody = aBody;
            this.Size.Width = (MyBody.MyHead.MyCharacter.Size.Width - MyBody.Size.Width) / 2;
            this.Size.Height = 2;
            IsLeft = aIsLeft;
            if (IsLeft)
                this.Location.Col = MyBody.MyHead.MyCharacter.Location.Col;
            else
                this.Location.Col = MyBody.Location.Col + MyBody.Size.Width;
            this.Location.Row = MyBody.Location.Row + (MyBody.Size.Height / 3);
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
                this.Location.Col = MyBody.MyHead.MyCharacter.Location.Col;
            else
                this.Location.Col = MyBody.Location.Col + MyBody.Size.Width;
            this.Location.Row = MyBody.Location.Row + (MyBody.Size.Height / 3);
        }

    }
}
