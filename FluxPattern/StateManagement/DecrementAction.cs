namespace FluxPattern.StateManagement
{
    public class DecrementAction : IAction
    {
        public const string DECREMENT = "DECREMENT";
        public string Name { get; } = DECREMENT;
    }
}
