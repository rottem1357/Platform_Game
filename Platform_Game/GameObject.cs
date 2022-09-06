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
    /// the most basic object in the game.
    /// every one of the objects in the game is a game object since it has
    /// size and location , it moves or stays still , and has a unique drawing method.
    /// </summary>
    internal abstract class GameObject
    {
        public Size Size { get; set; }
        public Location Location { get; set; }

        public abstract void Draw(Graphics canvas);
        public abstract void Move();
        public GameObject()
        {
            this.Size = new Size();
            this.Location = new Location();
        }
        public GameObject(Size aSize, Location aLocation)
        {
            this.Size = aSize;
            this.Location = aLocation;
        }

        /// <summary>
        /// determines whether two game objects intersect.
        /// ("touching each other").
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public bool IsIntersecting(GameObject g)
        {
            int r1Left, r2Left;
            int r1Width, r2Width;
            int r1Top, r2Top;
            int r1Height , r2Height;

            r1Left = this.Location.Col;
            r2Left = g.Location.Col;
            r1Width = this.Size.Width;
            r2Width = g.Size.Width;
            r1Top = this.Location.Row;
            r2Top = g.Location.Row;
            r1Height = this.Size.Height;
            r2Height = g.Size.Height;

            return !(r1Left > r2Left + r2Width) &&
                    !(r1Left + r1Width < r2Left) &&
                    !(r1Top > r2Top + r2Height) &&
                    !(r1Top + r1Height < r2Top);
        }
        /// <summary>
        /// background objects by defintion move only right.
        /// </summary>
        /// <returns></returns>
        public bool IsOutOfRightBound()
        {
            if (this.Location.Col > Settings.Width)
                return true;
            return false;
        }
        public bool IsOutOfBounds()
        {
            if (this.Location.Col + this.Size.Width > Settings.Width || this.Location.Col < 0)
                return true;
            return false;
        }
    }
}
