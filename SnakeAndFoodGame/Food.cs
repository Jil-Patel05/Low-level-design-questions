using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.SnakeAndFoodGame
{
    public abstract class Food
    {
        public Coords coords;
        public int bonusPoint;
        public Food(int x, int y, int bonusPoint)
        {
            this.coords.x = x;
            this.coords.y = y;
            this.bonusPoint = bonusPoint;
        }
    }

    public class NormalFood : Food
    {
        public NormalFood(int x, int y) : base(x, y, 1)
        {
        }
    }
    public class BonusFood : Food
    {
        public BonusFood(int x, int y) : base(x, y, 2)
        {
        }
    }
    public class PoisonousFood : Food
    {
        public PoisonousFood(int x, int y) : base(x, y, -1)
        {
        }
    }
}