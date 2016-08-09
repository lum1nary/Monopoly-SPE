using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using MonopolyCore.Card;

namespace MonopolyCore
{
    public interface IMonopolyPlayer : IMoneyContainer,IMonopolyEstateContainer
    {
        IMonopolyGame Game { get; }
        int CurrentMapPosition { get; }
        string PlayerName { get; }
        void Move(object sender,MovingEventArgs me);

    }

    public class MovingEventArgs : EventArgs
    {
        public int Count { get; }
        public MovingEventArgs(int count)
        {
            Count = count;
        }
    }

}
