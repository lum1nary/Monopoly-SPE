using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MonopolyCore
{
    
    public interface IMonopolyGame
    {
        Collection<IMonopolyPlayer> Players { get; }
        IMonopolyPlayer Bank { get; }
        GameMode Mode { get; }
        IMonopolyPlayer CurrentPlayer { get; }
        void Awake();
        void Start();
        void Prepare();
        void NextTurn();
        void End();
    }

    public enum GameMode {Normal,Fast}
}
