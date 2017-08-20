using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{

    class MyList
    {
        private Node indexNode { get; set; }
        private int count;
        public MyList()
        {
            this.indexNode = new Node(null);
            this.indexNode.previousNode = this.indexNode;
        }
        public void addObject(Object obj)
        {
            Node newNode = new Node(obj);
            Node tempNode = indexNode.previousNode;

            tempNode.nextNode = newNode;
            newNode.previousNode = tempNode;

            indexNode.previousNode = newNode;
            count++;
        }
        public Object removeObjectAtIndex(int index)
        {
            Node temp = nodeAtIndex(index);
            Node helpPreviousNode = temp.previousNode;
            Node helpNextNode = temp.nextNode;
            helpPreviousNode.nextNode = helpNextNode;
            helpNextNode.previousNode = helpPreviousNode;
            count--;
            return temp.nodeObj;
        }

        public int Count { get { return count; } }

        public Node nodeAtIndex(int Index)
        {
            Node current = indexNode.nextNode;
            int counter = 0;
            while (counter != Index)
            {
                current = current.nextNode;
                counter++;
            }
            return current;
        }
        public Object objectAtIndex(int Index)
        {
            return this.nodeAtIndex(Index).nodeObj;
        }
        public Iterator newIterator()
        {
            return new Iterator(indexNode);
        }
    }
}
