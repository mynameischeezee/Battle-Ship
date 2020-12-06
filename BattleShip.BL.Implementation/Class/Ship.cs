using BattleShip.BL.Abstarct.Enum;
using System.Collections.Generic;
using System.Drawing;

namespace BattleShip.BL.Implementation.Class
{
    public class Ship
    {
        public ShipOrientation Orientation;
        public Dictionary<Point, ShipState> ShipPosition;
        public ShipType Type;
        public ShipState State;
        public Ship(ShipType shipType, ShipOrientation orientation, Point head)
        {
            Type = shipType;
            Orientation = orientation;
            this.ShipPosition = new Dictionary<Point, ShipState>();
            CalculateShipPoints(head);
            State = ShipState.UnDamaged;
        }
        private void CalculateShipPoints(Point head)
        {
            if (this.Orientation == ShipOrientation.Horizontal)
            {
                for (int i = 0; i < (int)(Type); i++)
                {
                    Point Coordinate = head;
                    Coordinate.X += i;
                    this.ShipPosition.Add(Coordinate, ShipState.UnDamaged);
                }
            }
            else if (this.Orientation == ShipOrientation.Vertical)
            {
                for (int i = 0; i < (int)(Type); i++)
                {
                    Point Coordinate = head;
                    Coordinate.Y += i;
                    this.ShipPosition.Add(Coordinate, ShipState.UnDamaged);
                }
            }
        }
        public void CheckIfDead()
        {
            int HittedShipPartsAmount = 0;
            foreach (ShipState shipState in ShipPosition.Values)
            {
                if (shipState == ShipState.Damaged)
                {
                    HittedShipPartsAmount += 1;
                }
            }
            if (HittedShipPartsAmount == ShipPosition.Values.Count)
            {
                foreach (Point point in ShipPosition.Keys)
                {
                    ShipPosition[point] = ShipState.Dead;
                }
                State = ShipState.Dead;
            }
        }
    }
}
