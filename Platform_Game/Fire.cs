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
    /// <summary>
    /// this is a shotting skill available for characters.
    /// fire is a unit represented with red circle if it touches monster it looses Hp.
    /// fire shooting consumes character mp.
    /// </summary>
    internal class Fire : Skill
    {
        private Circle C{ get; set; }

        public Fire(GameObject aGameObject , bool aIsLeft) :base(new Location(),120,aIsLeft)
        {   
            this.Speed = Settings.MovementPixels * 3;

            if (aIsLeft)
                this.Location.Col = aGameObject.Location.Col;
            else
                this.Location.Col = aGameObject.Location.Col + aGameObject.Size.Width;

            this.Location.Row = aGameObject.Location.Row;
            this.C = new Circle(this.Location.Col,
                this.Location.Row + (MyRandom.Next(aGameObject.Size.Height / 2)),
                MyRandom.Next((aGameObject.Size.Height / 5), aGameObject.Size.Height / 4));
            this.Size.Height = C.R;
            this.Size.Width = C.R;
        }

        public override void Draw(Graphics canvas)
        {
            C.Draw(canvas, Brushes.Red);
            C.Draw(canvas , Pens.Black);
        }

        public override void Move()
        {
            if (IsLeft)
                this.Location.Col -= this.Speed;
            else 
                this.Location.Col += this.Speed;

            this.Range -= this.Speed;
            C.X = this.Location.Col;
        }
        public void CheckAndExecuteHit(List<Monster> monsters)
        { 
            foreach (Monster m in monsters)
                if(this.IsHitting(m))
                    m.TakeHit(MyRandom.Next(3, 10));
        }
    }
}
