using BattleShip.BL.Abstarct.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.BL.Implementation.Class.GameLogic
{
    public class Game
    {
        public User BluePlayer;
        public User RedPlayer;
        public User Turn;
        public GameState GameStatus;
        public User Winner;
        public Game(User Blue, User Red)
        {
            this.BluePlayer = Blue;
            this.RedPlayer = Red;
            this.Turn = Blue;
            this.GameStatus = GameState.Paused;
        }
    }
}
