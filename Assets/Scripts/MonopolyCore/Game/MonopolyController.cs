using System;
using UnityEngine;

namespace Assets.Scripts.MonopolyCore.Game
{
    public class MonopolyController : MonoBehaviour
    {
        #region Static Controller Singleton
        private static readonly Lazy<MonopolyController> _instanceContainer = new Lazy<MonopolyController>(FindInstanceInternal);

        public static MonopolyController GetInstance() => _instanceContainer.Value;

        private static MonopolyController FindInstanceInternal()
        {
            MonopolyController result = FindObjectOfType<MonopolyController>();
            
            if(result == null)
                throw new Exception("Monopoly Controller is not finded");

            if(FindObjectsOfType<MonopolyController>().Length > 1)
                throw new Exception("Monopoly Controller is not only controller");

            return result;
        }
        #endregion


        private readonly IMonopolyGame _game;
        private readonly GameStateBase _initialState;

        public IMonopolyGame Game => _game;

        public GameStateBase InitialState => _initialState;

        public GameStateBase Current { get; set; }

        public void Reset()
        {
            Current = _initialState;
        }

        public void InvokeAction()
        {
            Current.Action();
        }
    }
}