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
    /// <summary>
    /// Делегат функции выбора лучшего узла пути из двух.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    /// <param name="a">Первый узел пути.</param>
    /// <param name="b">Второй узел пути.</param>
    /// <returns>Возвращает лучший узел пути из двух.</returns>
    public delegate IPathNode<TNodeValue> ChooseBestPathNode<TNodeValue>(
        IPathNode<TNodeValue> a,
        IPathNode<TNodeValue> b);
}
