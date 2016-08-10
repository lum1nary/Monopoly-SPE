using System;
using Assets.Scripts.MonopolyCore.Card;

namespace Assets.Scripts.MonopolyCore
{
    public class MonopolyEstateContainerEventArgs : EventArgs
    {
        public IMonopolyEstateCard ActionItem { get; }
        public MonopolyEstateContainerEventArgs(IMonopolyEstateCard actionItem)
        {
            ActionItem = actionItem;
        }
    }
}