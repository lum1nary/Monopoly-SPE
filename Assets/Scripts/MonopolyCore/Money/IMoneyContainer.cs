using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Events;

namespace MonopolyCore
{
    public interface IMoneyContainer
    {
        int Money { get; }
        void Pay(IMoneyContainer conatiner,int value);
        void Take(int value);
        UnityEvent<object,MonopolyEstateContainerEventArgs> MoneyChanged { get; }
        
    }

    public class MonopolyMoneyEventArgs : EventArgs
    {
        public int oldValue { get; }
        public int newValue { get; }
        
        public MonopolyMoneyEventArgs(int _old, int _new)
        {
            oldValue = _old;
            newValue = _new;
        }
    }

}


