using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.TicTacToeDesign
{
    public enum PLAYER_SIGN
    {
        ROUND,
        CROSS,
        EMPTY
    }
    public class Player
    {
        public string Username { get; private set; }
        public PLAYER_SIGN PlayerSign { get; private set; }

        public Player(string username, PLAYER_SIGN playerSign)
        {
            this.Username = username;
            this.PlayerSign = playerSign;
        }
    }
}