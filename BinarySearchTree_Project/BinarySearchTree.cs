using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    public class BinarySearchTree
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
                            nodeToAdd.count++;
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
                            nodeToAdd.count++;
                            break;
                        }
                        else
                        {
                            //If the currentNode already has a childLess, make childMore the currentMode.
                            currentNode = currentNode.childLess;
                        }
                    }
                }
                //If nodeToAdd and currentNode are equal in value, increment currentNode.count.
                else
                {
                    currentNode.count++;
                }
            }
        }

        public bool Search(Node lookingForThis)
        {
            Node currentNode = ParentNode;
            while (true)
            {
                int answer = currentNode.data.CompareTo(lookingForThis.data);
                //CurrentNode is same as lookingForThis.
                if (answer == 0)
                {
                    return true;
                }
                //CurrentNode is < as lookingForThis.
                if (answer == -1)
                {
                    if (currentNode.childLess != null)
                    {
                        currentNode = currentNode.childLess;
                    }
                    else
                    {
                        return false;
                     }

                }
                else if (answer == 1)
                {
                    if(currentNode.childMore != null)
                    {
                        currentNode = currentNode.childMore;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
