using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Node
    {
        public Object nodeObj { get; }
        public Node previousNode { get; set; }
        public Node nextNode { get; set; }

        public Node(Object nodeObj)
        {
            this.nodeObj = nodeObj;
        }
    }
}
