using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
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
                return;
            }
            Root.Add(data);
            Count++;
        }
        public void Delete(T data)
        {
            if (Root.Data.CompareTo(data) == 0)
            {
                Root.Data = default;
                Count--;
                return;
            }
            Root.Delete(data);
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
        public void BFC ()
        {
            if (Root == null)
            {
                Console.WriteLine("В дереве нет элементов");
            }

            var queue = new Queue<Node<T>>();
            
            queue.Enqueue(Root);

            for (int i = 0; i < Count; i++)
            {
                if (queue.Peek().Left != null)
                {
                    queue.Enqueue(queue.Peek().Left);
                }
                if (queue.Peek().Right != null)
                {
                    queue.Enqueue(queue.Peek().Right);
                }
               
                Console.WriteLine(queue.Dequeue().Data);
            }
        }
        public void DFC ()
        {
            if (Root == null)
            {
                Console.WriteLine("В дереве нет элементов");
                return;
            }

            var stack = new Stack<Node<T>>();

            Node<T> Data;

            stack.Push(Root);

            for (int i = 0; i < Count; i++)
            {
                Data = stack.Peek();
                Console.WriteLine(stack.Pop().Data);
                if (Data.Right != null)
                {
                    stack.Push(Data.Right);
                }
                if (Data.Left != null)
                {
                    stack.Push(Data.Left);
                }
            }
        }
    }
}
