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

namespace Platform_Game
{
    internal abstract class Skill : GameObject
    {
        public int Range { get; set; }
        public bool IsLeft { get; set; }
        public int Speed { get; set; }

        public Skill(Location aStartingPoint , int aRange , bool aIsLeft) : base()
        { 
            this.Range = aRange;
            this.IsLeft = aIsLeft;
            this.Speed = Settings.MovementPixels * 2;
            this.Location.Col = aStartingPoint.Col;
            this.Location.Row = aStartingPoint.Row;
            this.Size.Width = 0;
            this.Size.Height = 0;
        }
        public bool IsOutOfRange()
        {
            if(this.Range >= 0)
                return false;
            return true;   
        }

        public bool IsHitting(GameObject a)
        {
            if (this.IsIntersecting(a))
                return true;
            return false;
        }
    }
}
