namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс узла пути.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла пути.</typeparam>
    public interface IPathNode<TNodeValue>
    {
        /// <summary>
        /// Предыдущий узел пути, из которого мы добрались до этого.
        /// </summary>
        public IPathNode<TNodeValue> PreviousNode { get; }
        /// <summary>
        /// Узел графа.
        /// </summary>
        public IGraphNode<TNodeValue> GraphNode { get; }
        /// <summary>
        /// Цена, за которую можно добраться до данного узла из стартового узла.
        /// </summary>
        public int Cost { get; }
    }
}
