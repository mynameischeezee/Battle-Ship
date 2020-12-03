using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGameService<T> where T: class
    {
        void AddShip(Point Coordinate);
        void ChangeTurn(T Player);
        T CheckForWinner();
        void Shot(T Player, T Enemy, Point Coordinate);
    }
}
