namespace FluxPattern.StateManagement
{
    public interface ICounterStore
    {
        CounterState State { get; protected set; }

        void Handle(IAction action);

        void AddCounterStoreListener(Action action);
        
        void RemoveCounterStoreListener(Action action);

    }
}
