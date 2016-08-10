using System;
using UnityEngine.Events;

namespace Assets.Scripts.MonopolyCore
{
    public class NativeEvent : UnityEvent<object,EventArgs>
    {
    }

    public class NativeEvent<T> : UnityEvent<object, T> where T : EventArgs
    {
        
    }
}