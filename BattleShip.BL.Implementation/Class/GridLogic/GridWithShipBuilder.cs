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
            this.Reset();
        }

        public override void AddShip(Point head, ShipType shipType, ShipOrientation shipOrientation)
        {
            grid.AddShip(new Ship(shipType, shipOrientation, head));
        }

        public override Grid CreateGrid(int size)
        {
            grid.CreateBySize(size);
            return this.ReturnGrid();
        }

        public override void Reset()
        {
            this.grid = new Grid();
        }
        public override Grid ReturnGrid()
        {
            Grid result = this.grid;
            this.Reset();
            return this.grid;
        }
    }
}
