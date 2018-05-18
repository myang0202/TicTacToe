using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.Interfaces;
using TicTacToe.Players;

namespace TicTacToe
{
    class GamePlayManager
    {
        GameBoard board;
        InputManager inputManager;
        OutputManager outputManager;
        IPlayer currentPlayer;
        GameState gameState;
        Move move;

        /// <summary>
        /// Main Contsructor
        /// </summary>
        public GamePlayManager()
        {
            GameBoard board = new GameBoard();
            InputManager inputManager = new InputManager();
            OutputManager outputManager = new OutputManager();
            this.board = board;
            this.inputManager = inputManager;
            this.outputManager = outputManager;

        }
        /// <summary>
        /// Contructor to test
        /// </summary>
        /// <param name="board"></param>
        /// <param name="inputManager"></param>
        /// <param name="output"></param>
        public GamePlayManager(GameBoard board, InputManager inputManager, OutputManager outputManager )
        {
            this.board = board;
            this.inputManager = inputManager;
            this.outputManager = outputManager;
        }
        /// <summary>
        /// Start game
        /// Create new player
        /// play until game is finished
        /// </summary>
        public void StartGame()
        {
            
            Player player = new Player();
            PC_Player computer = new PC_Player();
            PickFirstPlayer();

            while(gameState != GameState.GameOver)
            {
                currentPlayer = player;
                MakeMove();
                IsWin(currentPlayer,board);
                SwitchCurrentPlayer(currentPlayer);
            }
            

        }
        /// <summary>
        /// Current player makes move
        /// Print out Result
        /// </summary>
        public void MakeMove()
        {
            //take in input
            inputManager.ReadLine();
            if(!IsMoveValid(move))
            {
                throw new NotImplementedException();
            }
            outputManager.WriteLine();
        }
        /// <summary>
        /// See if player has won
        /// </summary>
        /// <param name="player"> Current player</param>
        /// <returns></returns>
        public Boolean IsWin(IPlayer player, GameBoard gameBoard)
        {
             throw new NotImplementedException();
        }
        /// <summary>
        /// Check if the move was valid
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public Boolean IsMoveValid(Move move)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Switch current player
        /// </summary>
        /// <param name="player"></param>
        public void SwitchCurrentPlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// pick first player
        /// </summary>
        public void PickFirstPlayer()
        {
            inputManager.ReadLine();
            // pick first player

        }
    }
}
