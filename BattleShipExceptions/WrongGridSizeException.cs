using System;

namespace BattleShip.Exceptions
{
    public class WrongGridSizeException : Exception
    {

        public WrongGridSizeException(string message) : base(message)
        {

        }
    }
}
