using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace MonopolyCore.Card
{
    public interface IMonopolyCardBase
    {
        IMonopolyPlayer Owner { get; }
        string Name { get; }
        int Position { get; }
        bool AllowPurchase { get; }
        //---------------------------
        void OnPlayerEnter(IMonopolyPlayer player);




    }
}
