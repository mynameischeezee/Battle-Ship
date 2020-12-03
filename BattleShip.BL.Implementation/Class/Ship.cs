using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BL.Abstarct.Enum;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace BattleShip.BL.Implementation.Class
{
    public class Ship
    {
        public ShipOrientation Orientation;
        public Dictionary<Point, ShipState> ShipPosition;
        public ShipType Type;
        public ShipState State;
        public Ship(){
        }
        public Ship(ShipType shipType, ShipOrientation orientation, Point head)
        {
            Type = shipType;
            Orientation = orientation;
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
        }
    }
}
