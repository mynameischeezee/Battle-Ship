using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
namespace BattleShip.BL.Abstarct.Interface
{
    public interface IStrategyShot<in T> where T : class
    {
        void Shot(T User,Point Coordinate);
    }
}
