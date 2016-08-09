using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyCore.Card
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
    
    

    public enum SetCardStatus
    {
        Normal, Doubled, W1House, W2House, W3House, W4House, WHotel
    }

    public enum ColorGroup
    {
        Purple = 1,
        LightBlue = 2,
        Pink = 3,
        Orange = 4,
        Red = 5,
        Yellow = 6,
        Green = 7,
        Blue = 8,
        Science = 9,
        Journey = 10
    }
}
