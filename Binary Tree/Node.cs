using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node
    {
        public int data;
        public Node nextNodeRight;
        public Node nextNodeLeft;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
