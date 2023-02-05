using System.Collections;
using System.Collections.Generic;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Саморасширяющийся узел графа, создающий новые рёбра и узлы, используя ленивую инициализацию.
    /// </summary>
    public class SelfExpendingGraphNode<TNodeValue> : ISelfExpendingGraphNode<TNodeValue>
    {
        public SelfExpendingGraphNode(
            IReadOnlyCollection<IGraphExpendingAction<TNodeValue>> expendingActions,
            TNodeValue value,
            IGraphExpendingAction<TNodeValue> cause = null)
        {
            _expendingActions = expendingActions;
            Value = value;
            Cause = cause;
        }

        public TNodeValue Value { get; }
        public IGraphExpendingAction<TNodeValue> Cause { get; }
        public IReadOnlyCollection<IGraphEdge<TNodeValue>> Edges
        {
            get
            {
                if (_edges is null)
                {
                    InitEdges();
                }
                return _edges;
            }
        }

        private List<SelfExpendingGraphEdge<TNodeValue>> _edges;
        private readonly IReadOnlyCollection<IGraphExpendingAction<TNodeValue>> _expendingActions;

        private void InitEdges()
        {
            _edges = new List<SelfExpendingGraphEdge<TNodeValue>>();
            foreach (IGraphExpendingAction<TNodeValue> expendingAction in _expendingActions)
            {
                if (expendingAction.IsPossibleToMake(Value))
                {
                    TNodeValue state = expendingAction.EvaluateResult(Value);
                    var selfExpendingNode = new SelfExpendingGraphNode<TNodeValue>(
                        _expendingActions,
                        state,
                        expendingAction);
                    var selfExpendingEdge = new SelfExpendingGraphEdge<TNodeValue>(
                        selfExpendingNode,
                        expendingAction);
                    _edges.Add(selfExpendingEdge);
                }
            }
        }

        public IEnumerator<IGraphEdge<TNodeValue>> GetEnumerator()
        {
            return _edges.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _edges.GetEnumerator();
        }
    }
}
