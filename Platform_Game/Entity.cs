/// <file>
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
    /// <summary>
    /// this abstract class is the base to every "living" object in the game.
    /// both players and monsters will move by the logic which is defined here.
    /// </summary>
    internal abstract class Entity : GameObject
    {
        private string NickName { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int Mp { get; set; }
        public int Level { get; set; }
        public int MyMomentum { get; set; }
        public bool IsDecending { get; set; }
        public bool IsAscending { get; set; }
        public bool IsGoingLeft { get; set; }
        public bool IsGoingRight { get; set; }
        public bool IsFacingLeft { get; set; }
        public Entity(string aNickName , Size aSize, Location aLocation):base(aSize,aLocation)
        {
            this.NickName = aNickName;
            this.MaxHp = Settings.MaxHp;
            this.MaxMp = Settings.MaxMp;
            this.Hp = this.MaxHp;
            this.Mp = this.MaxMp;
            this.Level = 1;
            this.MyMomentum = 0;
            this.IsDecending = true;
            this.IsAscending = false;
            this.IsGoingLeft = false;
            this.IsGoingRight = false;
            this.IsFacingLeft = false;
        }
        public Entity(string aNickName,int aLevel, Size aSize, Location aLocation) : base(aSize, aLocation)
        {
            this.NickName = aNickName;
            this.MaxHp = Settings.MaxHp;
            this.MaxMp = Settings.MaxMp;
            this.Hp = this.MaxHp;
            this.Mp = this.MaxMp;
            this.Level = aLevel;
            this.MyMomentum = 0;
            this.IsDecending = true;
            this.IsAscending = false;
            this.IsGoingLeft = false;
            this.IsGoingRight = false;
            this.IsFacingLeft = false;
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
        /// <summary>
        /// drawing elemnents common to every entity.
        /// </summary>
        /// <param name="canvas"></param>
        #region Draw addons
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
        #endregion

        /// <summary>
        /// movement logic.
        /// </summary>
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
            bool flag;
            Platform PlatformBase = Map.GetBasePlatform();
            flag = IsMidAir();  
            this.Location.Row += this.MyMomentum;
            if (this.MyMomentum < Settings.MaxMomentum)
                this.MyMomentum += 1;


            if(this.Location.Row + this.Size.Height >= PlatformBase.Location.Row)
            {
                this.Location.Row = PlatformBase.Location.Row - this.Size.Height;
                this.IsDecending = false;
                this.MyMomentum = 0;
                return;
            }

            if (flag)
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
