using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinarySearchTree
    {
        public Node rootNode;

        public BinarySearchTree()
        {

        }

        public void AddNode(Node nodeToAdd)
        {
            if(rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = rootNode;
                while (true)
                {
                    if (nodeToAdd.data < currentNode.data)
                    {
                        if(currentNode.nextNodeLeft == null)
                        {
                            currentNode.nextNodeLeft = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.nextNodeLeft;
                        }
                    }
                    else if(nodeToAdd.data > currentNode.data)
                    {
                        if(currentNode.nextNodeRight == null)
                        {
                            currentNode.nextNodeRight = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.nextNodeRight;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That number already exists in the binary tree.");
                    }
                }
            }
        }
    }
}
