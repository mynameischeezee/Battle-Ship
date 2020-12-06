using BattleShip.BL.Abstarct.Enum;
namespace BattleShip.BL.Abstarct.Interface
{
    public interface IGameConfiguration<Game> where Game : class
    {
        GameState StartGame(Game game);
        GameState FinishGame(Game game);
    }
}
