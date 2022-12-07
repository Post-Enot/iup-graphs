namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Ребро графа.
    /// </summary>
    /// <typeparam name="TNode">Тип узла графа.</typeparam>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public sealed class GraphEdge<TNodeValue> : IGraphEdge<TNodeValue>
    {
        public GraphEdge(IGraphNode<TNodeValue> direction, int cost)
        {
            Direction = direction;
            Cost = cost;
        }

        public int Cost { get; }
        public IGraphNode<TNodeValue> Direction { get; }
    }
}
