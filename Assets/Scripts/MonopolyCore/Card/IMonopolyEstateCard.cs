using Assets.Scripts.MonopolyCore.Player;

namespace Assets.Scripts.MonopolyCore.Card
{
    public interface IMonopolyEstateCard : IMonopolyCardBase
    {
        int PurchasePrice { get; }
        int RentPrice { get; }
        int LayPrice { get; }
        bool IsLayed { get; }
        bool InSet { get; }
        ColorGroup Group { get; }
        SetCardStatus SetStatus { get; }
        //------------------------
        void ChangeOwner(IMonopolyPlayer player);
        void UpdateRentPrice();
    }
}
