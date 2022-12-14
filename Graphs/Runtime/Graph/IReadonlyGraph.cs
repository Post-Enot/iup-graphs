using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс графа, доступный только для чтения.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значений узлов графа.</typeparam>
    public interface IReadonlyGraph<TNodeValue> : IReadOnlyCollection<IGraphNode<TNodeValue>>
    {
        /// <summary>
        /// Коллекция узлов графа.
        /// </summary>
        public IReadOnlyCollection<IGraphNode<TNodeValue>> Nodes { get; }
    }
}
