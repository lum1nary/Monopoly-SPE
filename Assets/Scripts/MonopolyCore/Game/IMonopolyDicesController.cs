namespace Assets.Scripts.MonopolyCore.Game
{
    public delegate void DicesDelegate(object sender, MovingEventArgs me);
    public interface IMonopolyDicesController
    {
        event DicesDelegate DicesDropped;
        void DropDices();

    }
}
