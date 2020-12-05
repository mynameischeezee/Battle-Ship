namespace BattleShip.BL.Abstarct.Interface
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void Notify();
    }
}
