using System;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Действие расширения саморасширяющегося графа.
    /// </summary>
    /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
    public class GraphExpendingAction<TNodeValue> : IGraphExpendingAction<TNodeValue>
    {
        public GraphExpendingAction(
            int cost,
            Predicate<TNodeValue> isPossibleToMakeAction,
            Func<TNodeValue, TNodeValue> evaluateActionResult,
            Action makeAction)
        {
            Cost = cost;
            _isPossibleToMakeAction = isPossibleToMakeAction;
            _evaluateActionResult = evaluateActionResult;
            _makeAction = makeAction;
        }

        public int Cost { get; }

        private readonly Func<TNodeValue, TNodeValue> _evaluateActionResult;
        private readonly Predicate<TNodeValue> _isPossibleToMakeAction;
        private readonly Action _makeAction;

        public bool IsPossibleToMake(TNodeValue nodeValue)
        {
            return _isPossibleToMakeAction(nodeValue);
        }

        public TNodeValue EvaluateResult(TNodeValue nodeValue)
        {
            return _evaluateActionResult(nodeValue);
        }

        public void Make()
        {
            _makeAction();
        }
    }
}
