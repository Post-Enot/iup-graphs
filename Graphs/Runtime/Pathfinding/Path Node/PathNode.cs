namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Узел пути.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла пути.</typeparam>
    public sealed class PathNode<TNodeValue> : IPathNode<TNodeValue>
    {
        public PathNode(
            IGraphNode<TNodeValue> graphNode,
            IPathNode<TNodeValue> previousNode = null,
            int cost = 0)
        {
            GraphNode = graphNode;
            PreviousNode = previousNode;
            Cost = cost;
        }

        public IPathNode<TNodeValue> PreviousNode { get; set; }
        public IGraphNode<TNodeValue> GraphNode { get; }
        public int Cost { get; set; }
    }
}
