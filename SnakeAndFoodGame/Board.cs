using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.SnakeAndFoodGame
{
    public class Board
    {
        public int height;
        public int width;
        private static Board instance;
        private static Object obj = new object();

        private Board(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public static Board getInstance(int height, int width)
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Board(height, width);
                    }
                }
            }
            return instance;
        }
    }
}