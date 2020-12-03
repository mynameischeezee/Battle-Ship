using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGameService<User,Game>
        where User: class
        where Game: class
        
    {
        void AddShip(Game Game,User user, Point Coordinate);
        void ChangeTurn(User Player, Game game);
        User CheckForWinner(Game game);
        void Shot(Game game,User Player, User Enemy, Point Coordinate,IStrategyShot<User> ShotContext);
    }
}
