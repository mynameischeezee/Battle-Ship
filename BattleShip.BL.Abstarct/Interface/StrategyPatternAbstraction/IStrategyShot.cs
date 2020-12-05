using System.Drawing;
namespace BattleShip.BL.Abstarct.Interface
{
    public interface IStrategyShot<in T> where T : class
    {
        void Shot(T Game, Point Coordinate);
    }
}
