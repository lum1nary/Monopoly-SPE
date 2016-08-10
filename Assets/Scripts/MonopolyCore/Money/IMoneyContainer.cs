using Assets.Scripts.MonopolyCore.Card;

namespace Assets.Scripts.MonopolyCore.Money
{
    public interface IMoneyContainer
    {
        int Money { get; }
        void Pay(IMoneyContainer conatiner,int value);
        void Take(int value);
        NativeEvent<MonopolyEstateContainerEventArgs> MoneyChanged { get; }
    }
}