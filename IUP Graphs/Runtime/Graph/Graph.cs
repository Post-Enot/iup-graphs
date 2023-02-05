using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Граф, состоящий из узлов и соединяющих их рёбер.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значений узлов графа.</typeparam>
    public sealed class Graph<TNodeValue> : IGraph<TNodeValue>
    {
        public int Count => Nodes.Count;
        public IReadOnlyCollection<IGraphNode<TNodeValue>> Nodes => _nodes;

        private readonly HashSet<IGraphNode<TNodeValue>> _nodes = new();

        public bool AddNode(IGraphNode<TNodeValue> node)
        {
            return _nodes.Add(node);
        }

        public bool RemoveNode(IGraphNode<TNodeValue> node)
        {
            return _nodes.Remove(node);
        }

        public bool ContainsNode(IGraphNode<TNodeValue> node)
        {
            return _nodes.Contains(node);
        }

        public IEnumerator<IGraphNode<TNodeValue>> GetEnumerator()
        {
            return _nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _nodes.GetEnumerator();
        }
    }
}
