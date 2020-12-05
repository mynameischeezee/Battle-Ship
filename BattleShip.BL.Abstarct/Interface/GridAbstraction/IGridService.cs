using System.Drawing;

namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGridService<Grid> where Grid : class
    {
        void MarkShip(Grid grid, Point coordinate);
        bool IsAvalibleToShot(Grid grid, Point coordinate);
    }
}
