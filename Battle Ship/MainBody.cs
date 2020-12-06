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
            GridView gridView = new GridView();
            Console.WriteLine(controller.StartGame("Sea", "Fire"));
            Console.WriteLine(controller.ReturnTurnPlayerName());
            Console.Write("Input grid size: ");
            try
            {
                controller.CreateGrid(Convert.ToInt32(Console.ReadLine()));
            }
            catch(Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Error: {e.Message}");
            }
            while (true)
            {
                Console.WriteLine("1. Add ship");
                Console.WriteLine("2. Shoot");
                try
                {
                    switch (Console.ReadLine())
                    {
                       case("1"): break;
                       case("2"): break;
                    }
                }
                catch(Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            controller.AddShip(new Point(0, 0), ShipOrientation.Horizontal, ShipType.Small);
            //gridView.PrintUserGrid(controller.game.Turn);
            //gridView.PrintShottedGrid(controller.game.Turn);
            controller.ChangeTurn();
            Console.WriteLine(controller.ReturnTurnPlayerName());
            controller.AddShip(new Point(0, 2), ShipOrientation.Horizontal, ShipType.Small);
            controller.Shot(4, new Point(0, 0));
            gridView.PrintShottedGrid(controller.game.Turn);
            controller.ChangeTurn();
            gridView.PrintUserGrid(controller.game.Turn);
            gridView.PrintShottedGrid(controller.game.Turn);
            controller.Shot(3, new Point(0, 0));
            gridView.PrintUserGrid(controller.game.Turn);
            gridView.PrintShottedGrid(controller.game.Turn);
            Console.ReadLine();


        }
    }
}
