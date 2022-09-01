using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal abstract class Entity : GameObject
    {
        protected static int IdGenerator { get; set; }
        public int Id { get; }
        public string NickName { get; set; }
        public int Hp { get; set; }
      
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int Mp { get; set; }
        public int Level { get; set; }
        public int Kills { get; set; }
        public int MyMomentum { get; set; }
        public bool IsDecending { get; set; }
        public bool IsAscending { get; set; }
        public bool IsGoingLeft { get; set; }
        public bool IsGoingRight { get; set; }
        public bool IsFacingLeft { get; set; }
        public Entity(string aNickName , Size aSize, Location aLocation):base(aSize,aLocation)
        { 
            IdGenerator = 0;
            this.NickName = aNickName;
            this.MaxHp = Settings.MaxHp;
            this.MaxMp = Settings.MaxMp;
            this.Hp = this.MaxHp;
            this.Mp = this.MaxMp;
            this.Id = IdGenerator;
            this.Level = 1;
            this.MyMomentum = 0;
            this.IsDecending = true;
            this.IsAscending = false;
            this.IsGoingLeft = false;
            this.IsGoingRight = false;
            this.IsFacingLeft = false;
            IdGenerator++;
        }
        public Entity(string aNickName,int aLevel, Size aSize, Location aLocation) : base(aSize, aLocation)
        {
            IdGenerator = 0;
            this.NickName = aNickName;
            this.MaxHp = Settings.MaxHp;
            this.MaxMp = Settings.MaxMp;
            this.Hp = this.MaxHp;
            this.Mp = this.MaxMp;
            this.Id = IdGenerator;
            this.Level = aLevel;
            this.MyMomentum = 0;
            this.IsDecending = true;
            this.IsAscending = false;
            this.IsGoingLeft = false;
            this.IsGoingRight = false;
            this.IsFacingLeft = false;
            this.Kills = 0;
            IdGenerator++;
        }

        public void LevelUp()
        {
            this.Level++;
        }

        public void TakeHit(int k)
        { 
            this.Hp -= k;   
        }

        public void Heal()
        {
            this.Hp += Settings.HealingPoints;
        }

        public bool IsDead()
        {
            if (this.Hp <= 0)
                return true;
            return false;
        }
        public void AddKill()
        {
            this.Kills++;
        }

        public void DrawLevel(Graphics canvas)
        {

            canvas.DrawString("lv." + this.Level.ToString(),
                Settings.NickNameFont,
                Brushes.Black,
                (float)(this.Location.Col),
                (float)(this.Location.Row) + (float)(this.Size.Height) + (float)8) ;
        }

        public void DrawNickName(Graphics canvas)
        {
            canvas.DrawString(this.NickName,
                Settings.NickNameFont,
                Brushes.Black,
                (float)(this.Location.Col),
                (float)(this.Location.Row) + (float)(this.Size.Height));
        }

        public void DrawHPBar(Graphics canvas)
        {
            canvas.FillRectangle(Brushes.Red,
                this.Location.Col,
                this.Location.Row - 8,
                (this.Hp * this.Size.Width) / this.MaxHp,
                4);
            canvas.DrawRectangle(Pens.Black, this.Location.Col,
                this.Location.Row - 8,
                this.Size.Width,
                4);
        }

        public void DrawEntityLevel(Graphics canvas)
        { 
            DrawHPBar(canvas);
            DrawNickName(canvas);
            DrawLevel(canvas);  
        }


        #region Movement
        public void MoveEntity()
        {
            if (this.IsDecending)
                this.Descend();
            if (this.IsAscending)
                this.Ascend();
            if (IsGoingRight)
                this.GoRight();
            if (this.IsGoingLeft)
                this.GoLeft();
        }
        public void GoLeft()
        {
            this.Location.Col -= Settings.MovementPixels;
            if (this.IsOutOfBounds())
                this.Location.Col = 0;
            this.IsFacingLeft = true;
            if(!this.IsAscending && !this.IsDecending)
                if (this.IsMidAir())
                    this.IsDecending = true;

        }
        public void GoRight()
        {
            this.Location.Col += Settings.MovementPixels;
            if (this.IsOutOfBounds())
                this.Location.Col = Settings.Width - this.Size.Width;
            this.IsFacingLeft = false;
            if (!this.IsAscending && !this.IsDecending)
                if (this.IsMidAir())
                    this.IsDecending = true;
        }
        public void Ascend()
        {
            this.Location.Row -= this.MyMomentum;
            if (this.MyMomentum > 0)
                this.MyMomentum -= 1;
            else
            {
                this.IsAscending = false;
                this.IsDecending = true;
            }
        }

        public bool IsMidAir()
        {
            foreach (Platform p in Map.platforms)
            {
                if (this.IsIntersecting(p))
                    return false;
            }
            return true;
        }
        public void Descend()
        {
            this.Location.Row += this.MyMomentum;
            if (this.MyMomentum < Settings.MaxMomentum)
                this.MyMomentum += 1;
            foreach (Platform p in Map.platforms)
            {
                if (this.IsIntersecting(p))
                {
                    this.Location.Row = p.Location.Row - this.Size.Height;
                    this.IsDecending = false;
                    this.MyMomentum = 0;
                    return;
                }
            }
        }

        public void Jump()
        {
            if (this.IsDecending || this.IsAscending)
                return;
            this.IsAscending = true;
            this.MyMomentum = Settings.MaxMomentum;
        }
        #endregion
    }
}
