using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using BattleShip.BL.Abstarct.Enum;

namespace BattleShip.BL.Implementation.Class.GridLogic
{
    public abstract class GridBuilder
    {
        public abstract void Reset();
        public abstract Grid CreateGrid(int size);
        public abstract void AddShip(Grid grid,Point point, ShipType shipType, ShipOrientation shipOrientation);
        public abstract Grid ReturnGrid();
        
    }
}
