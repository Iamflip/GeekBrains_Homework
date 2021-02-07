using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    class Edge
    {
        public int Weight { get; set; }
        public Vertex From { get; set; }
        public Vertex To { get; set; }

        public Edge(Vertex from, Vertex to)
        {
            From = from;
            To = to;
        }
        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }
    }
}
