using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyCore
{
    public delegate void DicesDelegate(object sender, MovingEventArgs me);
    public interface IMonopolyDicesController
    {
        event DicesDelegate DicesDropped;
        void DropDices();

    }
}
