using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_1
{
    class Tree<T>
        where T : IComparable<T>
    {
        public int Count { get; set; }
        public Node<T> Root { get; set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count++;
            }
            Root.Add(data);
            Count++;
        }
        public void Delete(T data)
        {
            var prew = Root;
            if (Root.Data.CompareTo(data) == 0)
            {
                Root.Data = default;
            }
            Root.Delete(data, prew);
            Count--;
        }
        public void Find(T data)
        {
            if (Root.Data.CompareTo(data) == 0)
            {
                Console.WriteLine(Root.Data.ToString());
            }
            Find(data);
        }
    }
}
