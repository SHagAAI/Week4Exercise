using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Queue
{
    public class QueuePriority
    {

        Dictionary<string, int> rules = new();
        List<StringCollection> listString = new();

        // public QueuePriority(char lttr, int p)
        // {
        //     letter = lttr;
        //     priority = p;
        // }

       

        public void AddRule(string keyword, int priority)
        {
            rules[keyword] = priority;
            Console.WriteLine($"Rule added {rules[keyword]}");
        }

        public void Enqueue(string val)
        {
            int wordPriority = 0;
            foreach (var item in rules)
            {
              
                if (  val.Contains(item.Key))
                {
                    if (item.Value > wordPriority)
                    {
                        wordPriority = item.Value;
                        
                    }
                } 
            }

            listString.Add(new StringCollection{letter=val, priority= wordPriority});
            Console.WriteLine($"Queued {val} with priority {wordPriority}");
            
        }
   
   
        public void Process()
        {

            if (listString.Count == 0)
            {
                Console.WriteLine("EMPTY");
                return;
            }
            int bigP = 0;
            int bigPIndex = 0;
            for (int i = 0; i < listString.Count; i++)
            {
                
                if (listString[i].priority > bigP)
                {

                    bigPIndex = i;
                    bigP = listString[i].priority;
                }
            }

            Console.WriteLine($"Processed {listString[bigPIndex].letter}");
            listString.RemoveAt(bigPIndex);
        }
    }
}