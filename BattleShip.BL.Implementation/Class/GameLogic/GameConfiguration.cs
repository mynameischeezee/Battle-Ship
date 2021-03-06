﻿using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GridLogic;

namespace BattleShip.BL.Implementation.Class.GameLogic
{
    public class GameConfiguration : IGameConfiguration<Game>
    {
        private IGridBuilder<Grid> builder;
        public GameConfiguration()
        {
            builder = new GridWithShipBuilder();
        }
        public GameState StartGame(Game game)
        {
            game.GameStatus = GameState.Started;
            return game.GameStatus;
        }
        public GameState FinishGame(Game game)
        {
            game.GameStatus = GameState.Finished;
            return game.GameStatus;
        }
        public void BuildGrid(Game game, int size)
        {
            game.RedPlayer.PlayerGrid = builder.CreateGrid(size);
            game.BluePlayer.PlayerGrid = builder.CreateGrid(size);
            game.RedPlayer.ShottedGrid = builder.CreateGrid(size);
            game.BluePlayer.ShottedGrid = builder.CreateGrid(size);
        }
    }
}
