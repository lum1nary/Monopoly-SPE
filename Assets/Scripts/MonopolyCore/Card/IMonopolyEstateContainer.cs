using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using UnityEngine.Events;
using MonopolyCore.Card;

namespace MonopolyCore
{
    public interface IMonopolyEstateContainer
    {
        Collection<IMonopolyEstateCard> Cards { get; }

        void PurchaseCard(IMonopolyEstateCard card);
        void GiveCard(IMonopolyEstateCard card, IMonopolyPlayer player);
        void TakeCard(IMonopolyEstateCard card);
        void Lay(IMonopolyEstateCard card);
        void BuyBack(IMonopolyEstateCard card);
        void UpdateGroupStatus(ColorGroup group);
        UnityEvent<object, MonopolyEstateContainerEventArgs> CardPurchased { get; }
        UnityEvent<object, MonopolyEstateContainerEventArgs> CardLayed { get; }
        UnityEvent<object, MonopolyEstateContainerEventArgs> CardBuyBacked { get; }
        UnityEvent<object, MonopolyEstateContainerEventArgs> CardToken { get; }
        UnityEvent<object, MonopolyEstateContainerEventArgs> CardGiven { get; }
    }

    public class MonopolyEstateContainerEventArgs : EventArgs
    {
        public IMonopolyEstateCard ActionItem { get; }
        public MonopolyEstateContainerEventArgs(IMonopolyEstateCard actionItem)
        {
            ActionItem = actionItem;
        }
    }
}
