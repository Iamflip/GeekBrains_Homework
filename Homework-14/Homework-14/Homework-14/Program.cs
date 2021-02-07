using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();

            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddVertex(7);
            graph.AddVertex(8);
            graph.AddVertex(9);


            graph.AddEdge(graph.V[0], graph.V[1]);
            graph.AddEdge(graph.V[0], graph.V[2]);
            graph.AddEdge(graph.V[0], graph.V[3]);
            graph.AddEdge(graph.V[1], graph.V[4]);
            graph.AddEdge(graph.V[1], graph.V[5]);
            graph.AddEdge(graph.V[2], graph.V[3]);
            graph.AddEdge(graph.V[2], graph.V[5]);
            graph.AddEdge(graph.V[3], graph.V[6]);
            graph.AddEdge(graph.V[3], graph.V[7]);
            graph.AddEdge(graph.V[5], graph.V[8]);
            graph.AddEdge(graph.V[6], graph.V[8]);

            graph.BFC();

        }
    }
}
