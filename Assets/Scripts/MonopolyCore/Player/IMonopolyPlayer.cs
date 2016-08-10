using Assets.Scripts.MonopolyCore.Card;
using Assets.Scripts.MonopolyCore.Game;
using Assets.Scripts.MonopolyCore.Money;

namespace Assets.Scripts.MonopolyCore.Player
{
    public interface IMonopolyPlayer : IMoneyContainer,IMonopolyEstateContainer
    {
        IMonopolyGame Game { get; }
        int CurrentMapPosition { get; }
        string PlayerName { get; }
        void Move(object sender,MovingEventArgs me);
    }
}