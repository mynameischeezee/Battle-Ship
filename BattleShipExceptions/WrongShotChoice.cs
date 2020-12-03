using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipExceptions
{
    public class WrongShotChoice : Exception
    {
        public WrongShotChoice(string message) : base(message)
        {

        }
    }
}
