
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Barte_SearchAlgo
{
    public class Graph
    {
        public int[,] Matrix;

        public void InitializeMatrix(int dimensions)
        {
            Matrix = new int[dimensions, dimensions];
            for (int i = 0; i < dimensions; i++)
            {
                for (int j = 0; j < dimensions; j++)
                {
                    Matrix[i, j] = i == j ? 0 : -1;
                }
            }
        }

        public void UpdateMatrix(List<Edge> edges)
        {
            foreach (Edge e in edges)
            {
                Matrix[e.From.IDX, e.To.IDX] = e.Cost;
                Matrix[e.To.IDX, e.From.IDX] = e.Cost;
            }
        }

        public List<Vertex> DFS_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {
            List<Vertex> order = new List<Vertex>();
            Stack<Vertex> stack = new Stack<Vertex>();

            stack.Push(start);
            while (stack.Count > 0)
            {
                Vertex curr = stack.Pop();
                if (curr.Equals(search))
                {
                    order.Add(curr);
                    return order;
                }


                if (!order.Contains(curr))
                {
                    order.Add(curr);

                    for (int i = 0; i < dimension; i++)
                    {
                        if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                        {
                            Vertex copy = new Vertex(vertices[i]);
                            copy.Ancestors.Add(curr);
                            copy.Ancestors.AddRange(curr.Ancestors);
                            stack.Push(copy);
                        }
                    }
                }
            }

            return order;
        }

        public List<Vertex> BFS_order(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {

            List<Vertex> order = new List<Vertex>();
            Queue<Vertex> queue = new Queue<Vertex>();

            queue.Enqueue(start);


            while (queue.Count > 0)
            {
                Vertex curr = queue.Dequeue();
                order.Add(curr);
                if (curr.Equals(search))
                {
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);
                        copy.Ancestors.AddRange(curr.Ancestors);
                        queue.Enqueue(copy);
                    }
                }
            }
            return order;
        }


        public List<Vertex> BranchAndBound(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {
            List<Vertex> order = new List<Vertex>();
            List<Vertex> queue = new List<Vertex> { start };

            while (queue.Count > 0)
            {
                Vertex curr = queue[0];
                queue.RemoveAt(0);
                order.Add(curr);
                if (curr.Equals(search))
                {
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);
                        copy.Ancestors.AddRange(curr.Ancestors);
                        copy.AccumulatedWeight = curr.AccumulatedWeight + Matrix[curr.IDX, i];
                        queue.Add(copy);
                    }
                }

                queue.Sort((x, y) => (x.AccumulatedWeight).CompareTo(y.AccumulatedWeight));
            }

            return order;
        }

        public List<Vertex> Beam(List<Vertex> vertices, Vertex start, Vertex search, int dimension, int width = 2)
        {

            List<Vertex> order = new List<Vertex>();     
            List<Vertex> queue = new List<Vertex>();

            queue.Add(start);


            while (queue.Count > 0)
            {
                Vertex curr = queue[0];
                queue.RemoveAt(0);
                order.Add(curr);
                if (curr.Equals(search))
                {
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {
                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);
                        copy.Heuristic = Util.distance(copy, search);
                        copy.Ancestors.AddRange(curr.Ancestors);
                        queue.Add(copy);
                    }
                }

                queue.Sort((x, y) =>
                {
                    int sumComparison = (x.Heuristic).CompareTo(y.Heuristic);

                    if (sumComparison == 0)
                    {

                        return x.ID.CompareTo(y.ID);
                    }

                    return sumComparison;
                });
                int NumToRemove = 0;
                if (queue.Count > width)
                {
                    NumToRemove = width - queue.Count;
                    queue.RemoveRange(width, NumToRemove);
                }


            }
            return order;

        }

        public List<Vertex> HillClimbing(List<Vertex> vertices, Vertex start, Vertex search, int dimension, int width = 1)
        {
            return Beam(vertices, start, search, dimension, 1);
        }

        public List<Vertex> AStar(List<Vertex> vertices, Vertex start, Vertex search, int dimension)
        {

            List<Vertex> order = new List<Vertex>();
            List<Vertex> queue = new List<Vertex>();

            start.Heuristic = Util.distance(start, search);
            queue.Add(start);

            while (queue.Count > 0)
            {
                Vertex curr = queue[0];
                queue.RemoveAt(0);
                order.Add(curr);

                if (curr.Equals(search))
                {
                    return order;
                }
                for (int i = 0; i < dimension; i++)
                {

                    if (Matrix[curr.IDX, i] > 0 && !curr.Has(vertices[i]))
                    {
                        Vertex copy = new Vertex(vertices[i]);
                        copy.Ancestors.Add(curr);
                        copy.Heuristic = Util.distance(copy, search);
                        copy.AccumulatedWeight += (curr.AccumulatedWeight + Matrix[curr.IDX, i]);
                        copy.Ancestors.AddRange(curr.Ancestors);
                        queue.Add(copy);
                    }
                }
                queue.Sort((x, y) =>
                {
                    int sumComparison = (x.Heuristic + x.AccumulatedWeight).CompareTo(y.Heuristic + x.AccumulatedWeight);
                    if (sumComparison == 0)
                    {
                        return x.ID.CompareTo(y.ID);
                    }

                    return sumComparison;
                });
            }
            return order;
        }

    }
}
