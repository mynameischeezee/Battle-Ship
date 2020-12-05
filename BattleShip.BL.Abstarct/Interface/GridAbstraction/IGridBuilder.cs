using BattleShip.BL.Abstarct.Enum;
using System.Drawing;

namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGridBuilder<Grid> where Grid : class
    {
        void Reset();
        Grid CreateGrid(int size);
        void AddShip(Grid grid, Point point, ShipType shipType, ShipOrientation shipOrientation);
        Grid ReturnGrid();
    }
}
