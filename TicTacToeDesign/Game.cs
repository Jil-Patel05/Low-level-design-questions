using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.LoggingDesign;

namespace LLD_Q.TicTacToeDesign
{
    public class Coords
    {
        public int X { get; set; }
        private int Y { get; set; }
        public Coords(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    public class Game
    {
        private Board Board { get; set; }
        private int size;
        private Logger logger;
        private IList<Player> players = new List<Player>();
        private short turn = 0;
        private int currentStep = 0;
        private Player currentPlayer;
        public Game(int height, int width, Logger logger)
        {
            this.logger = logger;
            this.Board = new Board(height, width, logger);
            this.size = height * width;
        }

        public void displayGame()
        {
            for (int i = 0; i < this.Board.Height; i++)
            {
                for (int j = 0; j < this.Board.Width; j++)
                {
                    if (this.Board.playerSignsBoard[i, j] == PLAYER_SIGN.EMPTY)
                    {
                        Console.Write("E ");
                    }
                    else if (this.Board.playerSignsBoard[i, j] == PLAYER_SIGN.ROUND)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
            this.logger.logMessage("Print is successfully Done", LOG_TYPE.INFO);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        private bool checkIsPlayerWinOrNot()
        {
            // Check row and columns if anf of them has same consucetive Playersign
            bool isWin = false;
            for (int i = 0; i < this.Board.Height; i++)
            {
                bool isRawMatched = true;
                for (int j = 0; j < this.Board.Width - 1; j++)
                {
                    if (this.Board.playerSignsBoard[i, j] != this.Board.playerSignsBoard[i, j + 1] || this.currentPlayer.PlayerSign != this.Board.playerSignsBoard[i, j])
                    {
                        isRawMatched = false;
                    }
                    if (this.Board.playerSignsBoard[j, i] != this.Board.playerSignsBoard[i, j + 1] || this.currentPlayer.PlayerSign != this.Board.playerSignsBoard[i, j])
                    {
                        isRawMatched = false;
                    }
                }
            }

            return isWin;
        }

        public bool playGame(int x, int y)
        {
            // X and Y comes here we have to validate it
            if (x >= this.Board.Height || x < 0 || y >= this.Board.Height || y < 0 || this.currentStep > this.size)
            {
                this.logger.logMessage("Please enter correct coords", LOG_TYPE.ERROR);
                return false;
            }
            this.currentStep++;
            this.turn ^= 1;
            this.currentPlayer = this.players[this.turn];
            this.logger.logMessage($"Current player is {this.currentPlayer.Username}", LOG_TYPE.INFO);
            this.Board.playerSignsBoard[x, y] = this.currentPlayer.PlayerSign;
            bool isWin = this.checkIsPlayerWinOrNot();
            return isWin;
        }
    }
}