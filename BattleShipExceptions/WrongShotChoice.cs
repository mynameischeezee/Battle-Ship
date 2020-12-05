using System;

namespace BattleShipExceptions
{
    public class WrongShotChoice : Exception
    {
        public WrongShotChoice(string message) : base(message)
        {

        }
    }
}
