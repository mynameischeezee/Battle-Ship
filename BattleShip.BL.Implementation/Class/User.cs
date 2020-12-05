namespace BattleShip.BL.Implementation.Class
{
    public class User
    {
        public string Name;
        public Grid PlayerGrid;
        public Grid ShottedGrid;
        public User(string name)
        {
            this.Name = name;
        }
    }
}
