using System;

namespace Assets.Scripts.MonopolyCore
{
    public class MovingEventArgs : EventArgs
    {
        public int Count { get; }
        public MovingEventArgs(int count)
        {
            Count = count;
        }
    }
}