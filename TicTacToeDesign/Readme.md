Tic Tac Toe game

Requirements:-

1. We have 2 player game, each player has one type of sign
2. When player has 3 consecutive Same type cell in any direction then they wins.
3. If nobody wins, game tie

Core Entities:-

1. Board -> width, height width == height
2. Player -> username and it's type
3. Game -> Which is to be played

DesignPatterns:-

1. Board -> Singleton
2. Observer -> When any player wins or match draw ties
