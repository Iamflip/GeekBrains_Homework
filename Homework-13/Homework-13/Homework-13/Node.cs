using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class Node<T>
            where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }
        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public void Delete(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (node.Data.CompareTo(Left.Data) == 0)
                {
                    Left = null;
                }
                else 
                {
                    Left.Delete(data);
                }
            }
            else
            {
                if (node.Data.CompareTo(Right.Data) == 0)
                {
                    Right = null;
                }
                else
                {
                    Right.Delete(data);
                }
            }
        }
        public void Find(T data)
        {
            if (data.CompareTo(Data) == -1)
            {
                Left.Find(data);
            }
            else if (data.CompareTo(Data) == 1)
            {
                Right.Find(data);
            }
            else
            {
                Console.WriteLine(Data.ToString());
            }
        }
        //private List<T> Postorder(Node<T> node)
        //{
        //    // Left Right Data
        //    var list = new List<T>();
        //    if (node.Left != null)
        //    {
        //        list.AddRange(Postorder(node.Left));
        //    }

        //    list.Add(node.Data);

        //    if (node.Right != null)
        //    {
        //        list.AddRange(Postorder(node.Right));
        //    }

        //    for (int i = list.Count - 1; i > +0; i--)
        //    {
        //        Delete(list[i], node);
        //    }
        //    return list;
        //}
        public int CompareTo(T other)
        {
            if (other is Node<T> item)
            {
                return Data.CompareTo(other);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
