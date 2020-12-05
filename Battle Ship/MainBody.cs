using BattleShip.BL.Abstarct.Enum;
using BattleShip.Controller;
using System;
using System.Drawing;

namespace Battle_Ship
{
    public class MainBody
    {
        public
        static void Main(string[] args)
        {
            ConsoleController controller = new ConsoleController();
            Console.WriteLine(controller.StartGame("Sea", "Fire"));
            Console.WriteLine(controller.ReturnTurnPlayerName());
            controller.ChangeTurn();
            Console.WriteLine(controller.ReturnTurnPlayerName());
            Console.ReadLine();
            controller.CreateGrid(20);
            Point point = new Point();
            point.X = 2;
            point.Y = 2;
            controller.AddShip(point, ShipOrientation.Horizontal, ShipType.Big);


        }
    }
}
