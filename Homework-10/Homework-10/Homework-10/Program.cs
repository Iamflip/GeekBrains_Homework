using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class Node
        {
            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }
        }
        public interface ILinkedList
        {
            int GetCount(); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // ищет элемент по его значению
        }
        public class LinkedList : ILinkedList
        {
            private int _count = 0;
            private Node _startNode;
            private Node _endNode;
            private Node _first;
            private Node _second;
            public void AddNode(int value)
            {
                if (_startNode == null)
                {
                    _startNode = new Node { Value = value };
                    _endNode = _startNode;
                }
                else
                {
                    _first = _startNode;
                    while (_first.NextNode != null)
                    {
                        _first = _first.NextNode;
                    }
                    _endNode = new Node { Value = value, PrevNode = _first };
                    _first.NextNode = _endNode;
                }

                _count++;
            }

            public void AddNodeAfter(Node node, int value)
            {
                _second = node.NextNode;
                node.NextNode = new Node { Value = value, NextNode = node.NextNode, PrevNode = node };
                _second.PrevNode = node.NextNode;

                _count++;
            }

            public Node FindNode(int searchValue)
            {
                _first = _startNode;
                while (_first.Value != searchValue)
                {
                    if (_first.NextNode == null)
                    {
                        Console.WriteLine("Такого элемента нет");
                        return null;
                    }
                    _first = _first.NextNode;
                }
                return _first;
            }

            public int GetCount()
            {
                return _count;
            }

            public void RemoveNode(int index)
            {
                _first = _startNode;
                int num = 1;
                while (num != index)
                {
                    _first = _first.NextNode;
                    num++;
                }

                _first = _first.PrevNode;
                _second = _second.NextNode;

                _first.NextNode = _second;
                _second.PrevNode = _first;

                _count--;
            }

            public void RemoveNode(Node node)
            {
                _first = node.PrevNode;
                _second = node.NextNode;

                _first.NextNode = _second;
                _second.PrevNode = _first;
            }
        }
    }
}
