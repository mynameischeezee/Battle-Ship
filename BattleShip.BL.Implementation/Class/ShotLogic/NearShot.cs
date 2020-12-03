using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.GridLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.ShotLogic
{
    public class NearShot : IStrategyShot<Game>
    {
        private GridService gridService = new GridService();
        public void Shot(Game game, Point Coordinate)
        {
            if (gridService.IsAvalibleToShot(game.Turn.PlayerGrid, Coordinate))
            {
                gridService.MarkShip(game.Turn.PlayerGrid, Coordinate);
            }
            else
            {
                this.Shot(game, Coordinate);
            }
        }
    }
}
