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
        public int RecoveryInterval { get; set; }

        public Queue<Fire> MyFire { get; set; }
        public Character(string aName, Size aSize , Location aLocation):base(aName , aSize, aLocation)
        { 
            this.Name = aName;
            MyDesign = new MyCharacterDesign(this);
            MyFire = new Queue<Fire>();
            this.RecoveryInterval = 0;
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
            {
                fire.Move();
                fire.CheckAndExecuteHit(Map.monsters);
                this.Kills+= Map.UpdateMonsters();
            }
              
            if (MyFire.Count != 0)
                while (MyFire.Peek().IsOutOfRange())
                {
                    MyFire.Dequeue();
                    if (MyFire.Count == 0)
                        break;
                }
            Recover();
        }

        

        public void Shoot()
        {
            if (this.Mp == 0)
                return;
            this.MyFire.Enqueue(new Fire(this, this.IsFacingLeft));
            this.Mp--;
        }

        public void Recover()
        {
            if (this.IsGoingLeft || this.IsGoingRight)
            {
                RecoveryInterval -= 2;
                return;
            }
            RecoveryInterval+= 10;
            if (RecoveryInterval < 300)
                return;

            if(this.Hp < this.MaxHp)
            {
                RecoveryInterval = 0;
                this.Hp += 10;
                if (this.Hp > this.MaxHp)
                    this.Hp = this.MaxHp;
            }

            if (this.Mp < this.MaxMp)
            {
                RecoveryInterval = 0;
                this.Mp += 20;
                if(Mp > this.MaxMp)
                    this.Mp = this.MaxMp;
            }
               
        }
    }
}
