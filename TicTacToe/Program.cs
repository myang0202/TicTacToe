using System;


namespace TicTacToe
{
    class Program
    {
        /// <summary>
        /// Start the game
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GamePlayManager gameManager = new GamePlayManager();
            gameManager.StartGame();
        }
    }
}
