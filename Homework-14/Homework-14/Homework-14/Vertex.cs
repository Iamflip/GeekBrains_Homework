using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_14
{
    class Vertex
    {
        public int Value { get; set; }
        public bool Visited { get; set; }

        public Vertex(int value)
        {
            Value = value;
        }
        
    }
}
