using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.TicTacToeDesign
{
    public class Board
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public Board(int height, int width)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}