using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class Fire : Skill
    {
        public Circle c { get; set; }

        public Fire(GameObject aGameObject , bool aIsLeft) :
            base(new Location(),
            120,
            aIsLeft)
        {
            Random random = new Random();   
            this.Speed = Settings.MovementPixels * 3;
            if (aIsLeft)
            {
                this.Location.Col = aGameObject.Location.Col;
                this.Location.Row = aGameObject.Location.Row;
                this.c = new Circle(this.Location.Col,
                    this.Location.Row + (random.Next(aGameObject.Size.Height / 2)),
                    random.Next((aGameObject.Size.Height / 5), aGameObject.Size.Height / 4));
            }
            else
            {
                this.Location.Col = aGameObject.Location.Col + aGameObject.Size.Width;
                this.Location.Row = aGameObject.Location.Row;
                this.c = new Circle(this.Location.Col + aGameObject.Size.Width,
                    this.Location.Row + (random.Next(aGameObject.Size.Height / 2)),
                    random.Next((aGameObject.Size.Height / 5), aGameObject.Size.Height / 4));
            }
            this.Size.Height = c.R;
            this.Size.Width = c.R;
        }

        public override void Draw(Graphics canvas)
        {
            c.Draw(canvas, Brushes.Red);
            c.Draw(canvas , Pens.Black);
        }

        public override void Move()
        {
            if (IsLeft)
            {
                this.Location.Col -= this.Speed;
                this.Range -= this.Speed;
                c.X = this.Location.Col;
            }
            else 
            {
                this.Location.Col += this.Speed;
                this.Range -= this.Speed;
                c.X = this.Location.Col;
            }
        }
        public void CheckAndExecuteHit(List<Monster> monsters)
        { 
            Random random = new Random();
            foreach (Monster m in monsters)
                if(this.IsHitting(m))
                    m.TakeHit(random.Next(3, 10));
        }
    }
}
