using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Делегат функции выбора наиболее подходящего узла пути для дальнейшего исследования в алгоритме 
    /// поиска пути.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    /// <param name="reachedNodes">Коллекция достигнутых узлов пути.</param>
    /// <returns>Возвращает наиболее подходящий узел пути для дальнейшего исследования в алгоритме 
    /// поиска пути.</returns>
    public delegate IPathNode<TNodeValue> NodeSelectionFunc<TNodeValue>(
        IReadOnlyCollection<IPathNode<TNodeValue>> reachedNodes);
}
