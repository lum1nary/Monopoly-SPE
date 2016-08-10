using System;
using UnityEngine;

namespace Assets.Scripts.MonopolyCore.Game
{
    public abstract class GameStateBase : MonoBehaviour
    {
        public abstract void Action();

        public NativeEvent<EventArgs> ActionInvoking { get; } = new NativeEvent<EventArgs>();
        
        public NativeEvent<EventArgs> ActionReportProgress { get; } = new NativeEvent<EventArgs>();
        
        public NativeEvent<EventArgs> ActionInvoked { get; } = new NativeEvent<EventArgs>();

        void Awake()
        {
            ActionInvoking.RemoveAllListeners();
            ActionInvoking.AddListener(OnActionInvokingInternal);

            ActionReportProgress.RemoveAllListeners();
            ActionInvoking.AddListener(OnActionReportProgress);

            ActionInvoked.RemoveAllListeners();
            ActionInvoked.AddListener(OnActionInvokedInternal);
        }

        #region Event Handlers
        protected virtual void OnActionInvoking(EventArgs args)
        {
        }

        protected virtual void OnActionReportProgress(EventArgs args)
        {
        }

        protected virtual void OnActionInvoked(EventArgs args)
        {
        }
        #endregion

        #region Event Rising
        protected void RaiseActionInvoking(EventArgs args)
        {
            ActionInvoking?.Invoke(this,args);
        }

        protected void RaiseActionReportProgress(EventArgs args)
        {
            ActionReportProgress?.Invoke(this, args);
        }

        protected void RaiseActionInvoked(EventArgs args)
        {
            ActionInvoked?.Invoke(this, args);
        }
        #endregion

        #region Intrnal Handlers
        private void OnActionInvokingInternal(object sender, EventArgs args)
        {
            OnActionInvoking(args);
        }

        private void OnActionInvokedInternal(object sender, EventArgs args)
        {
            OnActionInvoked(args);
        }

        private void OnActionReportProgress(object sender, EventArgs args)
        {
            OnActionReportProgress(args);
        }
        #endregion
    }
}