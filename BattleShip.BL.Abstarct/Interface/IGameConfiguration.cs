using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BL.Abstarct.Enum;
namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGameConfiguration<T> where T : class
    {
        GameState StartGame(T game);
        GameState FinishGame(T game);
    }
}
