using BattleShip.BL.Abstarct.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.GridLogic
{
    public class GridService
    {
        public void MarkShip(Grid grid, Point coordinate)
        {
            
         grid.GridSpace[coordinate.X, coordinate.Y] = CellState.Hitted;
                  
        }
        public bool IsAvalibleToShot(Grid grid, Point coordinate)
        {
            if (grid.GridSpace[coordinate.X, coordinate.Y] == CellState.Sea)
            {
                foreach (Ship ship in grid.Ships)
                {
                    if (ship.ShipPosition.ContainsKey(coordinate))
                    {
                        return true;
                    }
                }
                grid.GridSpace[coordinate.X, coordinate.Y] = CellState.Missed;
                return false;
            }
            else
            {
                return false;
            }
        }
    }
    
}
