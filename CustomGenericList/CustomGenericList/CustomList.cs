using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericList
{
    public class CustomList<T> : ICustomList<T>
    {
        public Node<T> headNode = null;

        
        public bool Exists()
        {
            return headNode != null;
        }

        public void AddItem(T data)
        {
            if(headNode == null)
            {
                headNode = new Node<T>(data);
            }
            else
            {
                Node<T> current = headNode;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node<T>(data);
            }
        }

        public void RemoveItem(T data)
        {
            if(headNode != null && Object.Equals(headNode.data, data))
            {
                Node<T> temp = headNode;
                headNode = temp.next;
                temp = null;
            }
            else
            {
                Node<T> temp = headNode;
                while(temp.next != null)
                {
                    if(Object.Equals(temp.next.data, data))
                    {
                        var node = temp.next;
                        temp.next = node.next;
                        node = null;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        public void AddToBeginning(T value)
        {
            if(headNode == null)
            {
                headNode = new Node<T>(value);
            }
            else
            {
                var node = new Node<T>(value);
                node.next = headNode;
                headNode = node;
            }
        }

        public void Print()
        {
            Node<T> current = headNode;
            while(current != null)
            {
                Console.WriteLine($"Element: {current.data.ToString()}");
                current = current.next;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = headNode;
            while(current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
