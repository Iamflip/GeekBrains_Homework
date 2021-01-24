using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12_1
{
    class Node<T>
        where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node<T> Parent { get; set; }

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
                    node.Parent = Left;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = node;
                    node.Parent = Right;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }
        public void Delete(T data, Node<T> prew)
        {
            if (data.CompareTo(Data) == -1)
            {
                prew = prew.Left;
                Left.Delete(data, prew);
            }
            else if (data.CompareTo(Data) == 1)
            {
                prew = prew.Right;
                Right.Delete(data, prew);
            }
            else
            {
                if (prew == prew.Left)
                {
                    if (prew.Left.Left == null && prew.Left.Right == null)
                    {
                        prew.Left = default;
                        prew.Left.Parent = default;
                    }
                    else if (prew.Left.Left != null)
                    {
                        Postorder(prew.Left);
                    }
                    else
                    {
                        Postorder(prew.Right);
                    }
                    
                }
                else
                {
                    if (prew.Right.Left == null && prew.Right.Right == null)
                    {
                        prew.Right = default;
                        prew.Right.Parent = default;
                    }
                    else if (prew.Right.Left != null)
                    {
                        Postorder(prew.Left);
                    }
                    else
                    {
                        Postorder(prew.Right);
                    }
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
        private List<T> Postorder(Node<T> node)
        {
            // Left Right Data
            var list = new List<T>();
            if (node.Left != null)
            {
                list.AddRange(Postorder(node.Left));
            }

            list.Add(node.Data);

            if (node.Right != null)
            {
                list.AddRange(Postorder(node.Right));
            }

            for (int i = list.Count-1; i >+ 0; i--)
            {
                Delete(list[i], node);
            }
            return list;
        }
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
