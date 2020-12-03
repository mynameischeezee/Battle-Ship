using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipExceptions
{
    public class UnAvalibleCellException : Exception
    {
        public UnAvalibleCellException(string message):base(message)
        {

        }
    }
}
