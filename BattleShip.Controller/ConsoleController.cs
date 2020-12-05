using BattleShip.BL.Abstarct.Enum;
using BattleShip.BL.Implementation.Class;
using BattleShip.BL.Implementation.Class.GameLogic;
using BattleShip.BL.Implementation.Class.ShotLogic;
using BattleShipExceptions;
using System;
using System.Drawing;

namespace BattleShip.Controller
{
    public class ConsoleController
    {
        public GameConfiguration Configuration = new GameConfiguration();
        public GameService Service = new GameService();
        public User Blue;
        public User Red;
        public Game game;
        public string StartGame(string BlueName, string RedName)
        {
            Blue = new User(BlueName);
            Red = new User(RedName);
            game = new Game(this.Blue, this.Red);
            Configuration.StartGame(game);
            return $"Game created." +
                $"{Environment.NewLine}" +
                $"Players:" +
                $"{Environment.NewLine}" +
                $"Blue player: {Blue.Name}{Environment.NewLine}" +
                $"VS{Environment.NewLine}" +
                $"Red player: {Red.Name}";
        }
        public void CreateGrid(int size)
        {
            Configuration.BuildGrid(game, size);
        }
        public void Shot(string Choice, Point Coordinate)
        {
            switch (Choice)
            {
                case ("1"): { Service.Shot(game, Coordinate, new LineShot()); break; }
                case ("2"): { Service.Shot(game, Coordinate, new NearShot()); break; }
                case ("3"): { Service.Shot(game, Coordinate, new RandomShot()); break; }
                case ("4"): { Service.Shot(game, Coordinate, new UserShot()); break; }
                default: { throw new WrongShotChoice("Wrong choice given, use 1-4 to select shot type"); }
            }
        }
        public void AddShip(Point Head, ShipOrientation orientation, ShipType type)
        {
            Service.AddShip(game, game.Turn, Head, type, orientation);
        }
        private void ChangeGameState(GameState state)
        {
            game.GameStatus = state;
        }
        public void FinishGame()
        {
            Configuration.FinishGame(game);
        }
        public void PauseGame()
        {
            this.ChangeGameState(GameState.Paused);
        }
        public string ReturnGameState()
        {
            return $"Current game state {Convert.ToString(this.game.GameStatus)}";
        }
        public string ReturnTurnPlayerName()
        {
            return $"Current turn is for player: {game.Turn.Name}";
        }
        public void ChangeTurn()
        {
            Service.ChangeTurn(game.NextTurn, game);
        }
    }
}
