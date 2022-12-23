namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс узла саморасширяющегося графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public interface ISelfExpendingGraphNode<TNodeValue> : IGraphNode<TNodeValue>
    {
        /// <summary>
        /// Действие, которое привело к текущему узлу.
        /// </summary>
        public IGraphExpendingAction<TNodeValue> Cause { get; }
    }
}
