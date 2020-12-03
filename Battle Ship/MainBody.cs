using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Implementation.Class;
using BattleShip.BL.Implementation.Class.GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Ship
{
    class MainBody
    {
        


        static void Main(string[] args)
        {
        User Red = new User();
        User Blue = new User();
        Red.Name = "Red";
            Blue.Name = "Blue";
            Game game = new Game();
            game.BluePlayer = Blue;
            game.RedPlayer = Red;
            GameConfiguration gameConfiguration = new GameConfiguration();
            gameConfiguration.StartGame(game);
            gameConfiguration.BuildGrid(game, 20);
            game.BluePlayer.PlayerGrid.GridSpace[2] = CellState.Dead;
            game.RedPlayer.PlayerGrid.GridSpace[2] = CellState.Sea;
            Console.WriteLine(game.BluePlayer.PlayerGrid.GridSpace[2]);
            Console.WriteLine(game.RedPlayer.PlayerGrid.GridSpace[2]);
            Console.ReadLine();


        }
    }
}
