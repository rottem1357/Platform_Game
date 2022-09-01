using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Platform_Game
{
    internal class Character : Entity
    {
        
        public string Name { get; set; }
        public MyCharacterDesign MyDesign { get; set; }

        public Queue<Fire> MyFire { get; set; }
        public Character(string aName, Size aSize , Location aLocation):base(aName , aSize, aLocation)
        { 
            this.Name = aName;
            MyDesign = new MyCharacterDesign(this);
            MyFire = new Queue<Fire>();
        }
        public Character(string aName,int aLevel, Size aSize, Location aLocation) : base(aName, aSize, aLocation)
        {
            this.Name = aName;
            MyDesign = new MyCharacterDesign(this);
            MyFire = new Queue<Fire>();
        }
        public override void Draw(Graphics canvas)
        {
            MyDesign.Draw(canvas);
            this.DrawEntityLevel(canvas);
            foreach (Fire fire in MyFire)
                fire.Draw(canvas);
        }
        public override void Move()
        {
            this.MoveEntity();
            MyDesign.Move();
            this.MyDesign.MyHead.UpdateFaceDirection(this.IsFacingLeft);

            foreach (Fire fire in this.MyFire)
                fire.Move();
            if (MyFire.Count != 0)
                while (MyFire.Peek().IsOutOfRange())
                {
                    MyFire.Dequeue();
                    if (MyFire.Count == 0)
                        break;
                }
        }

       

        public void Shoot()
        {
            this.MyFire.Enqueue(new Fire(this, this.IsFacingLeft));   
        }
    }
}
