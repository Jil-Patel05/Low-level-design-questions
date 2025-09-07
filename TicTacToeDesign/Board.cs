using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.LoggingDesign;

namespace LLD_Q.TicTacToeDesign
{
    public class Board
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public PLAYER_SIGN[,] playerSignsBoard;
        private Logger logger;
        public Board(int height, int width, Logger logger)
        {
            this.logger = logger;
            this.Width = width;
            this.Height = height;
            playerSignsBoard = new PLAYER_SIGN[this.Width, this.Height];
            this.InitalizeBoard();
        }

        private void InitalizeBoard()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    this.playerSignsBoard[i, j] = PLAYER_SIGN.EMPTY;
                }
            }
            this.logger.logMessage("Initialization Done", LOG_TYPE.INFO);
        }
    }
}