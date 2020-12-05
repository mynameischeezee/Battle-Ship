using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.GridLogic;
using BattleShipExceptions;
using System.Drawing;

namespace BattleShip.BL.Implementation.Class.ShotLogic
{
    public class UserShot : IStrategyShot<Game>
    {
        private IGridService<Grid> gridService = new GridService();
        public void Shot(Game game, Point Coordinate)
        {
            if (gridService.IsAvalibleToShot(game.Turn.PlayerGrid, Coordinate))
            {
                gridService.MarkShip(game.Turn.PlayerGrid, Coordinate);
            }
            else
            {
                throw new UnAvalibleCellException("This cell is already hitted, dead, or unvalible. Please choose another cell.");
            }
        }
    }
}
