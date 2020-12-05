using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Abstarct.Interface;
using BattleShip.Exceptions;
using System.Collections.Generic;

namespace BattleShip.BL.Implementation.Class
{
    public class Grid : IObservable
    {
        public CellState[,] GridSpace;
        public List<Ship> Ships;
        public List<IObserver> Observers;

        public Grid()
        {
            Ships = new List<Ship>();
        }
        public void AddShip(Ship ship)
        {
            Ships.Add(ship);
        }
        public void RemoveShip(Ship ship)
        {
            Ships.Remove(ship);
        }
        public void CreateBySize(int size)
        {
            if (size <= 0)
            {
                throw new WrongGridSizeException("Wrong grid size(0 or below given).");
            }
            else
            {
                GridSpace = new CellState[size, size];
            }
        }
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update();
            }
        }
    }
}
