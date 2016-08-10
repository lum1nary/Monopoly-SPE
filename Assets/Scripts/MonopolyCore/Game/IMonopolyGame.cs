using System.Collections.Generic;
using Assets.Scripts.MonopolyCore.Player;

namespace Assets.Scripts.MonopolyCore.Game
{
    public interface IMonopolyGame
    {
        ICollection<IMonopolyPlayer> Players { get; }
        IMonopolyPlayer Bank { get; }
        GameMode Mode { get; }
        IMonopolyPlayer CurrentPlayer { get; }
        void Awake();
        void Start();
        void Prepare();
        void NextTurn();
        void End();
    }
}