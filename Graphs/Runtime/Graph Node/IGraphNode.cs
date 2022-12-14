using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс узла графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public interface IGraphNode<TNodeValue> : IEnumerable<IGraphEdge<TNodeValue>>
    {
        /// <summary>
        /// Значение узла графа.
        /// </summary>
        public TNodeValue Value { get; }
        /// <summary>
        /// Коллекция рёбер узла графа.
        /// </summary>
        public IReadOnlyCollection<IGraphEdge<TNodeValue>> Edges { get; }
    }
}
