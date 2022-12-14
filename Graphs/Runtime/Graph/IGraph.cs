namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значений узлов графа.</typeparam>
    public interface IGraph<TNodeValue> : IReadonlyGraph<TNodeValue>
    {
        /// <summary>
        /// Добавляет переданный узел в граф.
        /// </summary>
        /// <param name="node">Узел графа.</param>
        /// <returns>Возвращает true, если добавление прошло успешно; 
        /// false, если граф уже содержит этот узел.</returns>
        public bool AddNode(IGraphNode<TNodeValue> node);

        /// <summary>
        /// Удаляет узел из графа.
        /// </summary>
        /// <param name="node">Узел графа.</param>
        /// <returns>Возвращает true, если удаление прошло успешно; 
        /// false, если граф не содержит переданный узел.</returns>
        public bool RemoveNode(IGraphNode<TNodeValue> node);

        /// <summary>
        /// Проверяет, содержит ли граф переданный узел.
        /// </summary>
        /// <param name="node">Узел графа.</param>
        /// <returns>Возвращает true, если граф содержит переданный узел; иначе false.</returns>
        public bool ContainsNode(IGraphNode<TNodeValue> node);
    }
}
