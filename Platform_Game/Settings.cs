using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Platform_Game
{
    internal class Settings
    {
        public static int RandonGenKey { get; set; }
        public static int Width{ get; set; }
        public static int Height{ get; set; }

        public static int Speed{ get; set; }

        public static int MaxHp { get; set; }
        public static int MaxMp { get; set; }

        public static Size CharacterSize { get; set; }

        public static Location StartingLocation { get; set; }

        public static int MaxMomentum { get; set; }
        
        public static int MovementPixels { get; set; }

        public static int HealingPoints { get; set; }

        public static Font NickNameFont { get; set; }

        public Settings(int aWidth, int aHeight)
        {
            Width = aWidth;
            Height = aHeight;
            Speed = 16;
            MaxHp = 100;
            MaxMp = 100;
            CharacterSize = new Size(aWidth / 22, aHeight / 10);
            StartingLocation = new Location(0, aHeight / 2);
            RandonGenKey = 40;
            MaxMomentum = 14;
            MovementPixels = 6;
            HealingPoints = 5;
            NickNameFont = new Font("Arial", 8);
        }

    }
}
