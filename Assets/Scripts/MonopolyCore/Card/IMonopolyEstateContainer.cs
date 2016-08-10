using System;
using System.Collections.Generic;
using Assets.Scripts.MonopolyCore.Player;
using UnityEngine.Events;

namespace Assets.Scripts.MonopolyCore.Card
{
    public interface IMonopolyEstateContainer
    {
        ICollection<IMonopolyEstateCard> Cards { get; }

        void PurchaseCard(IMonopolyEstateCard card);
        void GiveCard(IMonopolyEstateCard card, IMonopolyPlayer player);
        void TakeCard(IMonopolyEstateCard card);
        void Lay(IMonopolyEstateCard card);
        void BuyBack(IMonopolyEstateCard card);
        void UpdateGroupStatus(ColorGroup group);

        NativeEvent<MonopolyEstateContainerEventArgs> CardPurchased { get; }
        NativeEvent<MonopolyEstateContainerEventArgs> CardLayed { get; }
        NativeEvent<MonopolyEstateContainerEventArgs> CardBuyBacked { get; }
        NativeEvent<MonopolyEstateContainerEventArgs> CardToken { get; }
        NativeEvent<MonopolyEstateContainerEventArgs> CardGiven { get; }
    }

   
}
