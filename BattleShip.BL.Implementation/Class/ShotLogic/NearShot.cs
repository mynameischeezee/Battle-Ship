using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.GridLogic;
using System.Drawing;

namespace BattleShip.BL.Implementation.Class.ShotLogic
{
    public class NearShot : IStrategyShot<Game>
    {
        private IGridService<Grid> gridService = new GridService();
        public void Shot(Game game, Point Coordinate)
        {
            if (gridService.IsAvalibleToShot(game.Turn.PlayerGrid, Coordinate))
            {
            }
            else
            {
                this.Shot(game, Coordinate);
            }
        }
    }
}
