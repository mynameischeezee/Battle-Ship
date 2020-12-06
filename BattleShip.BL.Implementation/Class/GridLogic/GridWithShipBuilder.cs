using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Interface;
using System.Drawing;

namespace BattleShip.BL.Implementation.Class.GridLogic
{
    public class GridWithShipBuilder : IGridBuilder<Grid>
    {
        private Grid grid;
        public GridWithShipBuilder()
        {
            this.Reset();
        }
        public void AddShip(Grid grid, Point head, ShipType shipType, ShipOrientation shipOrientation)
        {
            grid.AddShip(new Ship(shipType, shipOrientation, head));
        }
        public Grid CreateGrid(int size)
        {
            this.Reset();
            grid.CreateBySize(size);
            return this.grid;
        }
        public void Reset()
        {
            this.grid = new Grid();
        }
        public Grid ReturnGrid()
        {
            Grid result = this.grid;
            this.Reset();
            return result;
        }
    }
}
