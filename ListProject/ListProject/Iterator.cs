using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Iterator
    {
        private Node indexNode { get; set; }
        Node currentNode { get; set; }
        public Iterator(Node indexNode)
        {
            this.indexNode = indexNode;
            this.currentNode = indexNode;
        }

        public Object next()
        {
            currentNode = hasNext() ? currentNode.nextNode : currentNode;
            return currentNode.nodeObj;
        }

        public Object previous()
        {
            currentNode = hasPrevious() ? currentNode.previousNode : currentNode;
            return currentNode.nodeObj;
        }

        public void reset()
        {
            currentNode = indexNode;
        }

        public bool hasNext()
        {
            return !(currentNode.nextNode == indexNode);
        }

        public bool hasPrevious()
        {
            return !(currentNode.previousNode == indexNode || currentNode == indexNode);
        }

    }
}
