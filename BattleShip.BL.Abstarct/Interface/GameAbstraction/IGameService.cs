using BattleShip.BL.Abstarct.Enum;
using System.Drawing;

namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGameService<User, Game>
        where User : class
        where Game : class
    {
        void AddShip(Game Game, User user, Point Coordinate, ShipType shipType, ShipOrientation shipOrientation);
        void ChangeTurn(User Player, Game game);
        User CheckForWinner(Game game);
        void Shot(Game game, Point Coordinate, IStrategyShot<Game> ShotContext);
    }
}
