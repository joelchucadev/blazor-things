namespace FluxPattern.StateManagement
{
    public class CounterStore : ICounterStore
    {
        
        private Action _listeners;

        public CounterStore(IActionDispatcher actionDispatcher)
        {
            actionDispatcher.Subscript(Handle);
            State = new CounterState();
        }

        public CounterState State { get; set; }

        public void Handle(IAction action)
        {
            switch(action.Name)
            {
                case "INCREMENT":
                    Increment();
                    break;
                case "DECREMENT":
                    Decrement();
                    break;
                default:
                    break;
            }
        }

        public void AddCounterStoreListener(Action action)
        {
            _listeners += action;            
        }

        public void RemoveCounterStoreListener(Action action)
        {
            _listeners -= action;
        }

        public void Increment()
        {
            State = new CounterState(State.Counter + 1);
            _listeners.Invoke();
        }

        public void Decrement()
        {
            State = new CounterState(State.Counter - 1);
            _listeners.Invoke();
        }
        
    }
}
