using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Interfaces;
namespace TicTacToe
{
    class GameBoard
    {
        IPlayer[,] cells;

        public GameBoard()
        {
            cells = new IPlayer[3, 3];
        }
    }
}
