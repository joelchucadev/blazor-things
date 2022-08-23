namespace FluxPattern.StateManagement
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _listeners;
        public void Subscript(Action<IAction> actionHandler)
        {
            _listeners += actionHandler;
        }

        public void Unscript(Action<IAction> actionHandler)
        {
            _listeners -= actionHandler;
        }

        public void Dispatch(IAction action)
        {
            _listeners.Invoke(action);
        }
    }
}
