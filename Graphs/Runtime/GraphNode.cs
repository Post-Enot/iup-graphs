using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Узел графа.
    /// </summary>
    /// <typeparam name="TNodeValue"></typeparam>
    public sealed class GraphNode<TNodeValue> : IGraphNode<TNodeValue>
    {
        public GraphNode(TNodeValue value)
        {
            Value = value;
            _edges = new();
        }

        public GraphNode(
            TNodeValue value,
            params IGraphEdge<TNodeValue>[] edges)
        {
            Value = value;
            _edges = new(edges);
        }

        public TNodeValue Value { get; }
        public IReadOnlyCollection<IGraphEdge<TNodeValue>> Edges => _edges;

        private readonly HashSet<IGraphEdge<TNodeValue>> _edges;

        /// <summary>
        /// Создаёт ребро графа.
        /// </summary>
        /// <param name="direction">Направление ребра.</param>
        /// <param name="cost">Цена ребра.</param>
        public void AddEdge(IGraphNode<TNodeValue> direction, int cost)
        {
            var edge = new GraphEdge<TNodeValue>(direction, cost);
            _ = _edges.Add(edge);
        }

        /// <summary>
        /// Удаляет переданное ребро графа.
        /// </summary>
        /// <param name="edge">Ребро графа.</param>
        /// <returns>Возвращает true, если удаление прошло успешно; false, если узел не содержит 
        /// переданное ребро графа.</returns>
        public bool RemoveEdge(IGraphEdge<TNodeValue> edge)
        {
            return _edges.Remove(edge);
        }

        /// <summary>
        /// Проверяет, содержит ли узел переданное ребро графа.
        /// </summary>
        /// <param name="edge">Ребро графа.</param>
        /// <returns>Возвращает true, если узел содержит переданное ребро графа; иначе false.</returns>
        public bool ContainsEdge(IGraphEdge<TNodeValue> edge)
        {
            return _edges.Contains(edge);
        }

        public IEnumerator<IGraphEdge<TNodeValue>> GetEnumerator()
        {
            return Edges.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Edges.GetEnumerator();
        }
    }
}
