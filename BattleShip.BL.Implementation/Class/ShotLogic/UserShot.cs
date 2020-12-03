using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.GridLogic;
using BattleShip.Exceptions;
using BattleShipExceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.ShotLogic
{
    public class UserShot : IStrategyShot<Game>
    {
        GridService gridService = new GridService();
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
