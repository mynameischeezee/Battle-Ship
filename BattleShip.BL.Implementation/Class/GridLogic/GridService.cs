using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Interface;
using System.Drawing;

namespace BattleShip.BL.Implementation.Class.GridLogic
{
    public class GridService : IGridService<Grid>
    {
        public void MarkShip(Grid grid, Point coordinate)
        {
            grid.GridSpace[coordinate.X, coordinate.Y] = CellState.Hitted;
            this.CheckShipState(grid);
            
        }
        public bool IsAvalibleToShot(Grid grid, Point coordinate)
        {
            if (coordinate.X > grid.GridSpace.GetLength(0) || coordinate.Y > grid.GridSpace.GetLength(1))
            {
                return false;
            }
            else if (grid.GridSpace[coordinate.X, coordinate.Y] == CellState.Sea)
            {
                foreach (Ship ship in grid.Ships)
                {
                    if (ship.ShipPosition.ContainsKey(coordinate) && ship.ShipPosition[coordinate] == ShipState.UnDamaged)
                    {
                        return true;
                    }
                }
                grid.GridSpace[coordinate.X, coordinate.Y] = CellState.Missed;
                return true;
            }
            else
            {
                return true;
            }
        }
        private void CheckShipState(Grid grid)
        {
            foreach (Ship ship in grid.Ships)
            {
                ship.CheckIfDead();
            }
        }
    }

}
