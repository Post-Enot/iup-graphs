using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Путь из узлов пути.
    /// </summary>
    /// <typeparam name="TNodeValue"></typeparam>
    public sealed class Path<TNodeValue>
    {
        /// <summary>
        /// Инициализирует поля, используя значения узлов пути.
        /// </summary>
        /// <param name="pathNodes"></param>
        public Path(IEnumerable<IPathNode<TNodeValue>> pathNodes)
        {
            PathNodes = new List<IPathNode<TNodeValue>>(pathNodes);
        }

        public IReadOnlyList<IPathNode<TNodeValue>> PathNodes { get; }

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
