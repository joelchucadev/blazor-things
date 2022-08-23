namespace FluxPattern.StateManagement
{
    public interface IActionDispatcher
    {
        void Subscript(Action<IAction> actionHandler);
        void Unscript(Action<IAction> actionHandler);
        void Dispatch(IAction action);
    }
}
