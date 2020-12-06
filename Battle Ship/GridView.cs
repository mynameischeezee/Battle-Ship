using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Struct;
using BattleShip.BL.Implementation.Class;
using System;
using System.Drawing;

namespace Battle_Ship
{
    public class GridView
    {
        private string ConvertShottedGridToString(Grid grid)
        {
            string result = " № ";
            for (int x = 0; x < grid.GridSpace.GetLength(0); x++)
            {
                result += $" {x} ";
            }
            result += System.Environment.NewLine;
            for (int x = 0; x < grid.GridSpace.GetLength(1); x++)
            {
                result += $"{x}: ";

                for (int y = 0; y < grid.GridSpace.GetLength(0); y++)
                {
                    switch (grid.GridSpace[x, y])
                    {
                        case CellState.Sea: result += $"[{CellCharacter.Sea}]"; break;
                        case CellState.Missed: result += $"[{CellCharacter.Missed}]"; break;
                        case CellState.Hitted: result += $"[{CellCharacter.Hitted}]"; break;
                        case CellState.Dead: result += $"[{CellCharacter.Dead}]"; break;
                    }
                }
                result += System.Environment.NewLine;
            }
            return result;
        }
        private string ConvertUserGridToString(Grid grid)
        {
            string result = " № ";
            for (int x = 0; x < grid.GridSpace.GetLength(0); x++)
            {
                result += $" {x} ";
            }
            result += System.Environment.NewLine;
            for (int x = 0; x < grid.GridSpace.GetLength(1); x++)
            {
                result += $"{x}: ";

                for (int y = 0; y < grid.GridSpace.GetLength(0); y++)
                {
                    if (IsShipThere(grid, x, y))
                    {
                        foreach (Ship ship in grid.Ships)
                        {
                            if (ship.ShipPosition.ContainsKey(new Point(x, y)))
                            {
                                switch (ship.ShipPosition[new Point(x, y)])
                                {
                                    case (ShipState.UnDamaged): result += $"[{ShipCharacter.UnDamaged}]"; break;
                                    case (ShipState.Damaged): result += $"[{CellCharacter.Hitted}]"; break;
                                    case (ShipState.Dead): result += $"[{CellCharacter.Dead}]"; break;
                                }
                            }
                        }
                    }
                    else
                    {
                        result += $"[{CellCharacter.Sea}]";
                    }
                }
                result += System.Environment.NewLine;
            }
            return result;
        }
        private bool IsShipThere(Grid grid, int x, int y)
        {
            foreach (Ship ship in grid.Ships)
            {
                if (ship.ShipPosition.ContainsKey(new Point(x, y)))
                {
                    return true;
                }
                
            }
            return false;
        }
        public void PrintShottedGrid(User user)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Shotted grid for player {user.Name}:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            string ConvertedGrid = this.ConvertShottedGridToString(user.ShottedGrid);

            foreach (char cell in ConvertedGrid)
            {
                if (Convert.ToString(cell).Equals(CellCharacter.Sea))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (Convert.ToString(cell).Equals(ShipState.UnDamaged))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else if (Convert.ToString(cell).Equals(ShipState.Dead))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (Convert.ToString(cell).Equals(CellCharacter.Hitted))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write(cell);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
        public void PrintUserGrid(User user)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Player grid for player {user.Name}:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            string ConvertedGrid = this.ConvertUserGridToString(user.PlayerGrid);
            foreach (char cell in ConvertedGrid)
            {
                if (Convert.ToString(cell).Equals(CellCharacter.Sea))
                {
                    
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (Convert.ToString(cell).Equals(ShipCharacter.Damagded))
                {
                    
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (Convert.ToString(cell).Equals(ShipCharacter.UnDamaged))
                {
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (Convert.ToString(cell).Equals(ShipCharacter.Dead))
                {
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(cell);
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
    }
}
