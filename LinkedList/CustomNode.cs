using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomNode
    {
        public CustomNode(int val)
        {
            myNum = val;
            Next = null;
            Prev = null;
        }

        public int myNum { get; set; }
        
        public CustomNode? Next {get; set;}
        public CustomNode? Prev {get; set;}

        
    }




}