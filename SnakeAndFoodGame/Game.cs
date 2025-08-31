using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.SnakeAndFoodGame
{
    public class Game
    {
        private Board board;
        private List<Food> foods = new List<Food>();
        private Coords head;
        private Coords tail;
        private LinkedList<Coords> snake = new LinkedList<Coords>();
        private Dictionary<Coords, bool> isSnake = new Dictionary<Coords, bool>();
        private MoveStrategy strategy;
        private int score = 0;
        public Game(int height, int width)
        {
            this.board = Board.getInstance(height, width);
            head = new Coords(0, 0);
            tail = head;
            snake.AddFirst(head);
            isSnake[head] = true;
            this.strategy = new MoveStrategy();
        }

        public void addFood(int x, int y)
        {
            Food fd = new NormalFood(x, y);
            foods.Add(fd);
        }

        public int move(string direction)
        {
            this.strategy.setStrategy(new HumanStrategy());
            Coords coord = this.strategy.giveNextCoords(head, direction);

            bool isOutOfBound = coord.x > board.width || coord.x < 0 || coord.y > board.height || coord.y < 0;
            bool isSnakeBody = isSnake.ContainsKey(coord);
            if (isOutOfBound || isSnakeBody)
            {
                return -1;
            }

            Food? food = this.foods.FirstOrDefault((item) => item.coords.x == coord.x && item.coords.y == coord.y);
            isSnake[coord] = true;
            snake.AddFirst(coord);
            head = coord;
            if (food == null)
            {
                Coords lastCoord = snake.Last.Value;
                isSnake[lastCoord] = false;
                snake.RemoveLast();
            }
            else
            {
                this.score += food.bonusPoint;
            }

            return this.score;
        }

        // 1,1,1,1,1  -> 1
    }
}