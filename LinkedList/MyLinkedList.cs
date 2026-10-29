using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList
    {
        public Func<int, int, int>? comparer;
        public List<Func<int, bool>> rules = new();
        public CustomNode? head;
        public CustomNode? tail;

        public void Print()
        {
            List<int> nodeVal = [];

            CustomNode? helperNode = head;
            while (helperNode != null)
            {
                if (rules.All(rule => rule(helperNode.myNum)))
                {
                    nodeVal.Add(helperNode.myNum);
                }
                helperNode = helperNode.Next;
            }


            // for (var myNode = head; myNode != null; myNode = myNode.Next)
            // {
            //     Console.WriteLine(myNode.myNum);
            //     nodeVal.Add(myNode.myNum);
            // }

            var comp = comparer;
            if (comp != null)
            {
                nodeVal = nodeVal.OrderBy(item => item, Comparer<int>.Create((param1, param2) => comp(param1, param2))).ToList();
            }

            Console.WriteLine(string.Join(", ", nodeVal));
        }

        public void Append(int val)
        {
            CustomNode newNode = new CustomNode(val);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;

            }
        }

        public void SetSorting(Func<int, int, int> comparer)
        {
            this.comparer = comparer;
        }

        public void AddFilter(Func<int, bool> filterRule)
        {
            rules.Add(filterRule);
        }

    }
}