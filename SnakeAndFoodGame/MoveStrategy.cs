using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.SnakeAndFoodGame
{
    public class MoveStrategy : IMoveStrategy
    {
        private IMoveStrategy strategy;
        public MoveStrategy()
        {
        }

        public void setStrategy(IMoveStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Coords giveNextCoords(Coords coord, string direction)
        {
            return this.strategy.giveNextCoords(coord, direction);
        }
    }
}