using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    class BinarySearchTree
    {
        public Node ParentNode;
        public void Add(Node nodeToAdd)
        {
            //If the search tree is empty, ParentMode will be null and the nodeToAdd will be added as the first node.
            if(ParentNode == null)
            {
                ParentNode = nodeToAdd;
            }
            else
            {
                Node currentNode = ParentNode;
                //If assesses whether we need to branch down childMore or childLess.
                //Branch down childMore.
                if(nodeToAdd.data > currentNode.data)
                {
                    while (true)
                    {
                        //If the currentNode has space available
                        if (currentNode.childMore == null)
                        {
                            //Assign nodeToAdd as this node's childMore.
                            //Break out of the while look once nodeToAdd has found a home.
                            currentNode.childMore = nodeToAdd;
                            break;
                        }
                        else
                        {
                            //If the currentNode already has a childMore, make childMore the currentNode.
                            currentNode = currentNode.childMore;
                        }
                    }
                }
                //Now we're branching down the childLess tree.
                else if (nodeToAdd.data < currentNode.data)
                {
                    while(true)
                    {
                        //If the currentNode has space available
                        if(currentNode.childLess == null)
                        {
                            //Assign nodeToAdd as this node's childLess.
                            //Break out of the while loop once nodeToAdd has found a home.
                            currentNode.childLess = nodeToAdd;
                            break;
                        }
                        else
                        {
                            //If the currentNode already has a childLess, make childMore the currentMode.
                            currentNode = currentNode.childLess;
                        }
                    }
                }
            }
        }

        public void Search()
        {
            //returns a specific value.
        }
    }
}
