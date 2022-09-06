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
        public int Kills { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        private MyCharacterDesign MyDesign { get; set; }
        private int RecoveryInterval { get; set; }  

        private Queue<Fire> MyFire { get; set; }
        private int HitInterval { get; set; }
        private Color MyColor { get; set; }
       
        public Character(string aName, Size aSize, Location aLocation) : base(aName, aSize, aLocation)
        {
            this.Name = aName;
            this.MyColor = Color.Blue;
            this.MyDesign = new MyCharacterDesign(this, this.MyColor);
            this.MyFire = new Queue<Fire>();
            this.RecoveryInterval = 0;
            this.IsAlive = true;
            this.HitInterval = 20;
            this.Kills = 0;
            
        }
        public Character(string aName, int aLevel,int aKills,Color aColor, Size aSize, Location aLocation) : base(aName, aSize, aLocation)
        {
            this.MyColor = aColor;
            this.Name = aName;
            this.MyDesign = new MyCharacterDesign(this , this.MyColor);
            this.MyFire = new Queue<Fire>();
            this.IsAlive = true;
            this.HitInterval = 20;
            this.Kills = aKills;
            
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
                this.AddKill(Map.UpdateMonsters());
            }

            if (MyFire.Count != 0)
                while (MyFire.Peek().IsOutOfRange())
                {
                    MyFire.Dequeue();
                    if (MyFire.Count == 0)
                        break;
                }
            Recover();
            if (this.IsHit())
            {
                this.Hp -= MyRandom.Next(10);
                if (this.Hp <= 0)
                    this.IsAlive = false;
            }
        }

        public bool IsHit()
        {
            if (this.HitInterval > 0)
            {
                this.HitInterval--;
                return false;
            }

            foreach (Monster m in Map.monsters)
            {
                if (this.IsIntersecting(m))
                {
                    this.HitInterval = 10;
                    return true;
                }


            }
            return false;
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
            RecoveryInterval += 10;
            if (RecoveryInterval < 300)
                return;

            if (this.Hp < this.MaxHp)
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
                if (Mp > this.MaxMp)
                    this.Mp = this.MaxMp;
            }

        }
        public void AddKill(int k)
        {
            this.Kills+= k;
            if (Kills >= this.Level * 10)
            {
                this.LevelUp();
                this.Kills = 0;
            }
        }
    }
}
