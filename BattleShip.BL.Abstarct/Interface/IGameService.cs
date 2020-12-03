using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using BattleShip.BL.Abstarct.Enum;

namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGameService<User,Game>
        where User: class
        where Game: class
    {
        void AddShip(Game Game,User user, Point Coordinate, ShipType shipType, ShipOrientation shipOrientation);
        void ChangeTurn(User Player, Game game);
        User CheckForWinner(Game game);
        void Shot(Game game, Point Coordinate,IStrategyShot<Game> ShotContext);
    }
}
