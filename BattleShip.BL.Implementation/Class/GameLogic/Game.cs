﻿using BattleShip.BL.Abstarct.Enum;

namespace BattleShip.BL.Implementation.Class.GameLogic
{
    public class Game
    {
        public User BluePlayer;
        public User RedPlayer;
        public User Turn;
        public User NextTurn;
        public GameState GameStatus;
        public User Winner;

        public Game(User Blue, User Red)
        {
            this.BluePlayer = Blue;
            this.RedPlayer = Red;
            this.Turn = Blue;
            this.NextTurn = Red;
            this.GameStatus = GameState.Paused;
        }
    }
}
