namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Ребро саморасширяющегося графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public class SelfExpendingGraphEdge<TNodeValue> : ISelfExpendingGraphEdge<TNodeValue>
    {
        public SelfExpendingGraphEdge(
            IGraphNode<TNodeValue> direction,
            IGraphExpendingAction<TNodeValue> action)
        {
            Cost = action.Cost;
            Direction = direction;
            Action = action;
        }

        public int Cost { get; }
        public IGraphNode<TNodeValue> Direction { get; }
        public IGraphExpendingAction<TNodeValue> Action { get; }
    }
}
