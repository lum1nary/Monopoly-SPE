using System;

namespace Assets.Scripts.MonopolyCore
{
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