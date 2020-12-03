using BattleShip.BL.Abstarct.Interface;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.GridLogic;
using BattleShipExceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.ShotLogic
{
    public class RandomShot : IStrategyShot<Game>
    {
        private GridService gridService = new GridService();
        private Random random = new Random();
        
        public void Shot(Game game, Point Coordinate)
        {
            Coordinate.X = random.Next(0, game.BluePlayer.PlayerGrid.GridSpace.Length - 1);
            Coordinate.Y = random.Next(0, game.BluePlayer.PlayerGrid.GridSpace.Length - 1);
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
