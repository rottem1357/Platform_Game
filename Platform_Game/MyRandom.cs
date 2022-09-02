using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform_Game
{
    internal class MyRandom
    {
        private static Random mRandom;
        public MyRandom()
        { 
            mRandom = new Random();    
        }

        public static int Next(int max)
        { 
            return mRandom.Next(max);
        }
        public static int Next(int min , int max)
        {
            return mRandom.Next(min , max);
        }
    }
}
