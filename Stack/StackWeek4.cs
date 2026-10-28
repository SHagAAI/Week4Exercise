using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class StackWeek4
    {
        public List<string> myStack = [];
        public List<string> undoStack = [];
        public List<Func<string, bool>> rules = new();


        public void Type(string text)
        {
            if (myStack.Count == 3)
            {
                myStack.RemoveAt(0);
                myStack.Add(text);
                Console.WriteLine($"Dropped bottom, Typed [{text}]");
                return;
            }
            Console.WriteLine($"Typed [{text}] ");
            myStack.Add(text);
        }

        public void TypeV2(string text)
        {

            if (rules.All(rule => rule(text)))
            {
                if (myStack.Count == 3)
                {
                    myStack.RemoveAt(0);
                    myStack.Add(text);
                    Console.WriteLine($"Dropped bottom, Typed [{text}]");
                    return;
                }
                Console.WriteLine($"Typed [{text}] ");
                myStack.Add(text);
            }
            else
            {
                Console.WriteLine($"Rejected [{text}]");
            }

        }

        public void Undo()
        {

            if (myStack.Count != 0)
            {

                var text = myStack[myStack.Count - 1];

                // move item to undo stack
                undoStack.Add(myStack[myStack.Count - 1]);

                // remove item
                myStack.RemoveAt(myStack.Count - 1);
                Console.WriteLine($"Undid [{text}] ");
                return;
            }

            Console.WriteLine("Stack Empty ");
        }

        public void Redo()
        {
            if (undoStack.Count == 0)
            {
                Console.WriteLine("NOTHING HERE BROTHER");
                return;
            }
            myStack.Add(undoStack[undoStack.Count - 1]);
            Console.WriteLine($"Redid [{undoStack[undoStack.Count - 1]}]");

            // clear history
            undoStack.Clear();
        }

        public void AddRule(Func<string, bool> rule)
        {
            rules.Add(rule);
        }
    }
}