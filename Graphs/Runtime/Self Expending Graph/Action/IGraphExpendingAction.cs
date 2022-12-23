namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Интерфейс действия расширения саморасширяющегося графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public interface IGraphExpendingAction<TNodeValue>
    {
        /// <summary>
        /// Стоимость совершения действия: в случае, если совершение возможно, стоимость ребра 
        /// саморасширяющегося графа будет равняться стоимости совершения действия.
        /// </summary>
        public int Cost { get; }

        /// <summary>
        /// Проверяет, возможно ли в данный момент совершить действие.
        /// </summary>
        /// <param name="nodeValue">Значение узла графа.</param>
        /// <returns>Возвращает true, если в данный момент возможно совершить действие.</returns>
        public bool IsPossibleToMake(TNodeValue nodeValue);

        /// <summary>
        /// Оценивает результат действия, возвращая значение узла графа.
        /// </summary>
        /// <param name="nodeValue">Значение узла графа.</param>
        /// <returns>Возвращает значение узла графа.</returns>
        public TNodeValue EvaluateResult(TNodeValue nodeValue);

        /// <summary>
        /// Совершает репрезентующее действие.
        /// </summary>
        public void Make();
    }
}
