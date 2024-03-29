﻿/// <file>
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
    internal class Map
    {
        public static List<Platform> platforms;
        public static List<Monster> monsters;
        private static Queue<Cloud> clouds;
        private static Queue<Bird> birds;

        public Map()
        {
            clouds = new Queue<Cloud>();
            birds = new Queue<Bird>();
            monsters = new List<Monster>();

            // my platforms defintion done here manually.
            platforms = new List<Platform>();
            platforms.Add(new Platform(new Size(Settings.Width, Settings.Height / 20),
                new Location(8 * (Settings.Height / 10), 0)));
            platforms.Add(new Platform(new Size(Settings.Width / 2, Settings.Height / 20),
               new Location(5 * (Settings.Height / 10), 0)));
            platforms.Add(new Platform(new Size(3 * Settings.Width / 7, Settings.Height / 20),
             new Location(6 * (Settings.Height / 10), 2 * (Settings.Width / 3))));
        }

        public void AddMonster()
        {
            int k = MyRandom.Next(1, 4);
            monsters.Add(new Monster(k.ToString(), new Size(3 * Settings.CharacterSize.Width / 2, 3 * Settings.CharacterSize.Height / 2),
                new Location(MyRandom.Next(Settings.Width / 2), MyRandom.Next(Settings.Height / 2))));
        }
        public void AddPlatform(Platform p)
        {
            platforms.Add(p);
        }

        public void AddBird(Bird b)
        {
            birds.Enqueue(b);
        }
        public void AddCloud(Cloud c)
        {
            clouds.Enqueue(c);
        }

        #region generation
        public void RandomBirdGeneration()
        {
            int k;
            k = MyRandom.Next(Settings.RandonGenKey);

            if (k == 2)
                birds.Enqueue(new Bird(new Size(30, 30), new Location(0, -30)));
        }
        public void RandomCloudGeneration()
        {
            int k;
            k = MyRandom.Next(Settings.RandonGenKey);

            if (k == 1)
                clouds.Enqueue(new Cloud(5, new Size(200, 100), new Location(0, -200)));
        }
        public void RandomMonsterGeneration()
        {
            while (monsters.Count < 3)
                this.AddMonster();
        }
        public void RandomGen()
        { 
            RandomBirdGeneration();
            RandomCloudGeneration();
            RandomMonsterGeneration();
        }
        #endregion

        public void Draw(System.Drawing.Graphics canvas)
        {
            foreach (Platform p in platforms)
                p.Draw(canvas);
            foreach (Bird b in birds)
                b.Draw(canvas);
            foreach (Cloud c in clouds)
                c.Draw(canvas);
            foreach (Monster m in monsters)
                m.Draw(canvas);
        }

        /// <summary>
        /// move all map objects
        /// </summary>
        public void Move()
        {
            foreach (Bird b in birds)
                b.Move();
            foreach (Cloud c in clouds)
                c.Move();
            foreach (Monster m in monsters)
                m.Move();
            if (birds.Count != 0)
                if (birds.Peek().IsOutOfRightBound())
                    birds.Dequeue();
            if (clouds.Count != 0)
                if (clouds.Peek().IsOutOfRightBound())
                    clouds.Dequeue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>how many monsters have been updated</returns>
        public static int UpdateMonsters()
        {
            int counter = 0;
            for (int i = 0; i < monsters.Count; i++)
                if (monsters[i].Hp <= 0)
                {
                    monsters.RemoveAt(i);
                    counter++;
                }
            return counter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The lowest platform that exists</returns>
        public static Platform GetBasePlatform()
        {
            int currIndex = 0;
            for (int index = 0; index < platforms.Count; index++)
                if (platforms[index].Location.Row >= platforms[currIndex].Location.Row)
                    currIndex = index;
            return platforms[currIndex];
        }
    }
}
