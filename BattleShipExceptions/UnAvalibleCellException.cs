using System;

namespace BattleShipExceptions
{
    public class UnAvalibleCellException : Exception
    {
        public UnAvalibleCellException(string message) : base(message)
        {

        }
    }
}
