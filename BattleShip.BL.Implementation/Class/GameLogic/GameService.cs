using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GridLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.GameLogic
{
    public class GameService : IGameService<User,Game>
    {
        IStrategyShot<Game> ContextShot;
        GridWithShipBuilder builder = new GridWithShipBuilder();

        public void AddShip(Game Game, User user, Point Coordinate, ShipType shipType, ShipOrientation shipOrientation)
        {
            builder.AddShip(user.PlayerGrid, Coordinate, shipType, shipOrientation);
        }

        public void ChangeTurn(User Player, Game game)
        {
            game.Turn = Player;
        }

        public User CheckForWinner(Game game)
        {
            throw new NotImplementedException();
        }

        public void Shot(Game game, Point Coordinate, IStrategyShot<Game> ContextShot)
        {
            this.ContextShot = ContextShot;
            ContextShot.Shot(game, Coordinate);
        }
    }
}
