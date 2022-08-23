namespace FluxPattern.StateManagement
{
    public class IncrementAction : IAction
    {
        public const string INCREMENT = "INCREMENT";
        public string Name { get; } = INCREMENT;
    }
}
