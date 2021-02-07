using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    class Graph
    {
        public List<Vertex> V = new List<Vertex>();
        public List<Edge> E = new List<Edge>();
        public int VertexCount { get; set; }
        public int EdgeCount { get; set; }
        public void AddVertex(int value)
        {
            var vertex = new Vertex(value);
            V.Add(vertex);
            VertexCount++;
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            E.Add(edge);
            EdgeCount++;
        }
        public void AddEdge(Vertex from, Vertex to, int weight)
        {
            var edge = new Edge(from, to, weight);
            E.Add(edge);
            EdgeCount++;
        }
        //проход в ширину
        public void BFC()
        {
            var queue = new Queue<Vertex>();

            queue.Enqueue(V[0]);

            Console.WriteLine(queue.Peek().Value);


            for (int i = 0; i < VertexCount; i++)
            {
                for (int j = 0; j < EdgeCount; j++)
                {
                    if (E[j].To.Value == V[i].Value && !E[j].To.Visited)
                    {
                        queue.Enqueue(E[j].To);
                        Console.WriteLine(queue.Peek().Value);
                        E[j].To.Visited = true;
                    }
                }
                queue.Dequeue();
            }
        }
        //проход в глубину
        public void DFC()
        {
            var stack = new Stack<Vertex>();
            stack.Push(V[0]);

            for (int i = 0; i < VertexCount; i++)
            {
                Console.WriteLine(stack.Peek().Value);
                Vertex Data = stack.Pop();

                for (int j = EdgeCount - 1; j >= 0; j--)
                {
                    if (E[j].From.Value == Data.Value && !E[j].To.Visited)
                    {
                        stack.Push(E[j].To);
                        E[j].To.Visited = true;
                    }
                }
            }
        }
        public int [,] GetMatrix()
        {
            int[,] matrix = new int [VertexCount, VertexCount];

            foreach (var edge in E)
            {
                var row = edge.From.Value;
                var column = edge.To.Value;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }
        public List<Vertex> GetVertexList(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in E)
            {
                if (edge.From.Value == vertex.Value)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }

    }
}
