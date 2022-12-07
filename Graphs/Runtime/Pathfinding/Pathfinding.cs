using System;
using System.Collections.Generic;
using UnityEngine;

namespace IUP.Toolkits.Graphs
{
    /// <summary>
    /// Статический класс, содержащий методы поиска пути для графов.
    /// </summary>
    public static class Pathfinding
    {
        /// <summary>
        /// Метод поиска пути для графа.
        /// </summary>
        /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
        /// <param name="startNode">Начальный узел графа, с которого начинается поиск пути.</param>
        /// <param name="isPathFind">Предикат, принимающий в качестве аргумента узел пути и проверяющий, 
        /// удовлетворяет ли он условию нахождения пути.</param>
        /// <param name="nodeSelectionFunc">Функция выбора наиболее подходящего узла графа для 
        /// дальнейшего исследования в алгоритме поиска пути.</param>
        /// <returns>Возвращает объект класса пути.</returns>
        public static Path<TNodeValue> FindPath<TNodeValue>(
            IGraphNode<TNodeValue> startNode,
            Predicate<IPathNode<TNodeValue>> isPathFind,
            NodeSelectionFunc<TNodeValue> nodeSelectionFunc)
        {
            var pathNodeByGraphNode = new Dictionary<IGraphNode<TNodeValue>, PathNode<TNodeValue>>();
            var reachedNodes = new HashSet<IPathNode<TNodeValue>>();
            var exploredNodes = new HashSet<IGraphNode<TNodeValue>>();
            var startPathNode = new PathNode<TNodeValue>(startNode);
            reachedNodes.Add(startPathNode);
            pathNodeByGraphNode.Add(startNode, startPathNode);
            while (reachedNodes.Count != 0)
            {
                IPathNode<TNodeValue> exploredPathNode = nodeSelectionFunc(reachedNodes);
                if (isPathFind(exploredPathNode))
                {
                    return BuildPath(exploredPathNode);
                }
                _ = reachedNodes.Remove(exploredPathNode);
                _ = exploredNodes.Add(exploredPathNode.GraphNode);
                foreach (IGraphEdge<TNodeValue> edge in exploredPathNode.GraphNode.Edges)
                {
                    IGraphNode<TNodeValue> adjacentNode = edge.Direction;
                    if (!exploredNodes.Contains(adjacentNode))
                    {
                        if (!pathNodeByGraphNode.ContainsKey(adjacentNode))
                        {
                            var adjacentPathNode = new PathNode<TNodeValue>(
                                adjacentNode,
                                exploredPathNode,
                                edge.Cost);
                            pathNodeByGraphNode.Add(adjacentNode, adjacentPathNode);
                            _ = reachedNodes.Add(adjacentPathNode);
                        }
                        else
                        {
                            PathNode<TNodeValue> adjacentPathNode = pathNodeByGraphNode[adjacentNode];
                            int costFromChoosenToAdjacent = exploredPathNode.Cost + edge.Cost;
                            if (costFromChoosenToAdjacent < adjacentPathNode.Cost)
                            {
                                adjacentPathNode.PreviousNode = exploredPathNode;
                                adjacentPathNode.Cost = costFromChoosenToAdjacent;
                            }
                        }
                    }
                }
            }
            return new Path<TNodeValue>();
        }

        /// <summary>
        /// Создаёт объект класса пути на основе конечного узла пути.
        /// </summary>
        /// <typeparam name="TNodeValue">Тип значения узла графа.</typeparam>
        /// <param name="finalPathNode">Конечный узел пути.</param>
        /// <returns>Возвращает объект класса пути на основе конечного узла пути.</returns>
        private static Path<TNodeValue> BuildPath<TNodeValue>(
            IPathNode<TNodeValue> finalPathNode)
        {
            IPathNode<TNodeValue> pathNode = finalPathNode;
            var path = new List<IPathNode<TNodeValue>>();
            while (pathNode.PreviousNode != null)
            {
                path.Add(pathNode);
                pathNode = pathNode.PreviousNode;
            }
            path.Reverse();
            foreach (var p in path)
            {
                if (p != null)
                {
                    Debug.Log(p.GraphNode.Value);
                }
            }
            return new Path<TNodeValue>(path);
        }
    }
}
