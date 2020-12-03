using BattleShip.BL.Abstarct.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.GridLogic
{
    public class GridWithShipBuilder : GridBuilder
    {
        private Grid grid;
        public GridWithShipBuilder()
        {
            grid = new Grid();
        }

        public override void AddShip(Point point, ShipType shipType, ShipOrientation shipOrientation)
        {
            grid.AddShip(new Ship());
        }

        public override void CreateGrid(int size)
        {
            grid.CreateBySize(size);
        }

        public override Grid ReturnGrid()
        {
            return this.grid;
        }
    }
}
