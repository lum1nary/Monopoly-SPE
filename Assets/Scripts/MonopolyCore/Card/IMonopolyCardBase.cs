using Assets.Scripts.Data;
using Assets.Scripts.MonopolyCore.Player;

namespace Assets.Scripts.MonopolyCore.Card
{
    public interface IMonopolyCardBase
    {
        IMonopolyPlayer Owner { get; }
        CardInfo Info { get; }
        bool AllowPurchase { get; }
        //---------------------------
        void OnPlayerEnter(IMonopolyPlayer player);
    }
}
