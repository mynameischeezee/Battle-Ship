using BattleShip.BL.Abstarct.Interface;
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
        IStrategyShot<User> ContextShot;

        public void AddShip(Game Game, User user, Point Coordinate)
        {
            throw new NotImplementedException();
        }

        public void ChangeTurn(User Player, Game game)
        {
            game.Turn = Player;
        }

        public User CheckForWinner(Game game)
        {
            throw new NotImplementedException();
        }

        public void Shot(Game game, User Player, User Enemy, Point Coordinate, IStrategyShot<User> ContextShot)
        {
            this.ContextShot = ContextShot;
            ContextShot.Shot(Player, Coordinate);
            throw new NotImplementedException();
        }
    }
}
