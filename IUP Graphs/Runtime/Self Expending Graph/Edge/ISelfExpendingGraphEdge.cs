namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс ребра саморасширяющегося графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public interface ISelfExpendingGraphEdge<TNodeValue> : IGraphEdge<TNodeValue>
    {
        /// <summary>
        /// Действие расширения узла саморасширяющегося графа, репрезентующее данное ребро.
        /// </summary>
        public IGraphExpendingAction<TNodeValue> Action { get; }
    }
}
