namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс ребра графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public interface IGraphEdge<TNodeValue>
    {
        /// <summary>
        /// Стоимость перехода по ребру графа.
        /// </summary>
        public int Cost { get; }
        /// <summary>
        /// Направление перехода ребра графа.
        /// </summary>
        public IGraphNode<TNodeValue> Direction { get; }
    }
}
