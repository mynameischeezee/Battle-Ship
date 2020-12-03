using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Implementation.Class;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.GridLogic;
using BattleShip.BL.Implementation.Class.ShotLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Controller
{
    public class ConsoleController
    {
        public User Blue;
        public User Red;
        public Game game;
        public string StartGame(string BlueName, string RedName)
        {
            Blue = new User(BlueName);
            Red = new User(RedName);
            game = new Game(this.Blue, this.Red);
            return $"Game created.Players:" +
                $"{Environment.NewLine}{ConsoleColor.Blue}" +
                $"Blue player{Blue.Name}{Environment.NewLine}" +
                $"{ConsoleColor.White}VS{Environment.NewLine}" +
                $"{ConsoleColor.Red}Red player:{Red.Name}";
        }
        public void ChangeGameState(GameState state)
        {
            game.GameStatus = state;
        }
    }
}
