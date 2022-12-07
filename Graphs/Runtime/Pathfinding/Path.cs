using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Путь из узлов пути.
    /// </summary>
    /// <typeparam name="TNodeValue"></typeparam>
    public sealed class Path<TNodeValue>
    {
        /// <summary>
        /// Инициализирует поля пустыми коллекциями.
        /// </summary>
        public Path()
        {
            Nodes = new IGraphNode<TNodeValue>[0];
            Costs = new int[0];
        }

        /// <summary>
        /// Инициализирует поля, используя значения узлов пути.
        /// </summary>
        /// <param name="pathNodes"></param>
        public Path(IEnumerable<IPathNode<TNodeValue>> pathNodes)
        {
            var values = new List<IGraphNode<TNodeValue>>();
            var costs = new List<int>();
            foreach (var pathNode in pathNodes)
            {
                //values.Add(pathNode.GraphNode);
                //costs.Add(pathNode.Cost);
            }
            Nodes = values;
            Costs = costs;
        }

        /// <summary>
        /// Список значений узлов пути: нулевой индекс является начальной точкой.
        /// </summary>
        public IReadOnlyList<IGraphNode<TNodeValue>> Nodes { get; }
        /// <summary>
        /// Список стоимости перемещения по узлам пути: индекс отражает номер узла пути.
        /// </summary>
        public IReadOnlyList<int> Costs { get; }
    }
}
