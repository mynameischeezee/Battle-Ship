using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.Exceptions
{
    public class WrongGridSizeException : Exception
    {
        
        public WrongGridSizeException(string message) : base(message)
        {
            
        }
    }
}
