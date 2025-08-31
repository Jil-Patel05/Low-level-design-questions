using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.SnakeAndFoodGame
{
    public interface IMoveStrategy
    {
        public Coords giveNextCoords(Coords coord, string direction);
    }

    public class HumanStrategy : IMoveStrategy
    {
        public Coords giveNextCoords(Coords coord, string direction)
        {
            switch (direction)
            {
                case "U":
                    return new Coords(coord.x - 1, coord.y);
                case "D":
                    return new Coords(coord.x + 1, coord.y);
                case "R":
                    return new Coords(coord.x, coord.y + 1);
                default:
                    return new Coords(coord.x, coord.y - 1);
            }
        }
    }

    public class AIStrategy : IMoveStrategy
    {
        public Coords giveNextCoords(Coords coord, string direction)
        {
            switch (direction)
            {
                case "U":
                    return new Coords(coord.x - 1, coord.y);
                case "D":
                    return new Coords(coord.x + 1, coord.y);
                case "R":
                    return new Coords(coord.x, coord.y + 1);
                default:
                    return new Coords(coord.x, coord.y - 1);
            }
        }
    }
}