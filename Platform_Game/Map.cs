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
        private Queue<Cloud> clouds;
        private Queue<Bird> birds;
        

        public Map()
        { 
            clouds = new Queue<Cloud>();
            birds = new Queue<Bird>();
            platforms = new List<Platform>();   
            platforms.Add(new Platform(new Size(Settings.Width, Settings.Height / 20),
                new Location(8 * (Settings.Height / 10), 0)));
            platforms.Add(new Platform(new Size(Settings.Width / 3, Settings.Height / 20),
               new Location(5 * (Settings.Height / 10), 0)));
            platforms.Add(new Platform(new Size(Settings.Width / 3, Settings.Height / 20),
             new Location(6 * (Settings.Height / 10),2 * (Settings.Width /3))));
            platforms.Add(new Platform(new Size(Settings.Width / 3, Settings.Height / 20),
            new Location(3 * (Settings.Height / 10),  Settings.Width / 3)));
            monsters = new List<Monster>();
        }

        public void AddMonster()
        { 
            monsters.Add(new Monster("Bill",new Size(Settings.CharacterSize.Width * 2 , Settings.CharacterSize.Height * 2),
                new Location(Settings.Width /2, Settings.Height / 2)));
        }
        public void AddPlatform(Platform p)
        {
            platforms.Add(p);
        }

        public void AddBird(Bird b)
        { 
            this.birds.Enqueue(b);
        }
        public void AddCloud(Cloud c)
        { 
            this.clouds.Enqueue(c); 
        }

        public void RandomBirdGeneration()
        {
            int k;
            Random random = new Random();
            k = random.Next(Settings.RandonGenKey);

            if (k == 2)
                birds.Enqueue(new Bird(new Size(30, 30), new Location(0, -30)));
        }

        public void RandomCloudGeneration()
        {
            int k;
            Random random = new Random();
            k = random.Next(Settings.RandonGenKey);

            if (k == 1)
                clouds.Enqueue(new Cloud(5, new Size(200, 100), new Location(0, -200)));
        }

        public void RandomMonsterGeneration()
        {
            while (monsters.Count < 3)
                this.AddMonster();
        }

        public void Draw(System.Drawing.Graphics canvas)
        { 
            foreach (Platform p in platforms)
                p.Draw(canvas);
            foreach (Bird b in this.birds)
                b.Draw(canvas);
            foreach(Cloud c in this.clouds)
                c.Draw(canvas);
            foreach(Monster m in monsters)
                m.Draw(canvas);
        }

        public void Move()
        {
            foreach (Bird b in this.birds)
                b.Move();
            foreach (Cloud c in this.clouds)
                c.Move();
            foreach (Monster m in monsters)
                m.Move();
            if(birds.Count != 0)
                if (birds.Peek().IsOutOfRightBound())
                    birds.Dequeue();
            if(clouds.Count != 0)
                if(clouds.Peek().IsOutOfRightBound())
                    clouds.Dequeue();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>how many monsters have been updated</returns>
        public static int UpdateMonsters()
        {
            int counter = 0;
            for(int i = 0; i < monsters.Count; i++)
                if(monsters[i].Hp <= 0)
                {
                    monsters.RemoveAt(i);
                    counter++;
                }
            return counter;
        }
    }
}
