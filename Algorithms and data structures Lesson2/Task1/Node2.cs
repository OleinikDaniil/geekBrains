using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsTests
{
    public class Node2
    {
        public int Value { get; set; }
        public Node2 NextNode { get; set; }
        public Node2 PrevNode { get; set; }
    }
    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface IILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node2 node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node2 node); // удаляет указанный элемент
        Node2 FindNode(int searchValue); // ищет элемент по его значению
    }

    public class TwoLinkedList : IILinkedList
    {
        private int _count;

        private Node2 _startnode;
        private Node2 _endnode;

        public void AddNode(int value)
        {
            if(_startnode == null)
            {
                _startnode = new Node2 { Value = value };
                _startnode = _endnode;
            }
            else
            {
                if (_endnode.PrevNode == null)
                {
                    _endnode = new Node2 { Value = value };
                    _startnode.NextNode = _endnode;
                    _endnode.PrevNode = _startnode;
                }
                else
                {
                    var node = _endnode.PrevNode;
                    _endnode = new Node2 { Value = value };
                    node.NextNode = _endnode;
                    _endnode.PrevNode = node;
                }
            }
            _count++;
        }

        public void AddNodeAfter(Node2 node, int value)
        {
            if (node == _endnode)
            {
                AddNode(value);
                return;
            }
            var nodeAfter = node.NextNode;
            var newNode = new Node2 { Value = value };
            node.NextNode = newNode;
            newNode.PrevNode = node;
            newNode.NextNode = nodeAfter;
            nodeAfter.PrevNode = newNode;
            _count++;
        }

        public Node2 FindNode(int searchValue)
        {
            var currentNode = _startnode;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                    return currentNode;
                currentNode = currentNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            return _count;
        }

        public void RemoveNode(int index)
        {
            if (index > _count-1)
                return;
            if (index == 0)
            {
                var afterNode = _startnode.NextNode.NextNode;
                _startnode = _startnode.NextNode;
                _startnode.NextNode = afterNode;
                afterNode.PrevNode = _startnode;
                _count--;
                return;
            }
            if (index == _count)
            {
                var beforeNode = _endnode.PrevNode.PrevNode;
                _endnode = _endnode.PrevNode;
                _endnode.PrevNode = beforeNode;
                beforeNode.PrevNode = _endnode;
                _count--;
                return;
            }
            int searchIndex = 1;
            var nodeToRemove = _startnode.NextNode;
            while (searchIndex != index)
            {
                nodeToRemove = nodeToRemove.NextNode;
                searchIndex++;
            }
            var prevNode = nodeToRemove.PrevNode;
            var nextNode = nodeToRemove.NextNode;
            prevNode.NextNode = nextNode;
            nextNode.PrevNode = prevNode;
            _count--;
        }

        public void RemoveNode(Node2 node)
        {
            if (node == _startnode)
                RemoveNode(1);
            if (node == _endnode)
                RemoveNode(_count);
            var prevNode = node.PrevNode;
            var nextNode = node.NextNode;
            prevNode.NextNode = nextNode;
            nextNode.PrevNode = prevNode;
            _count--;
        }
    }
}
