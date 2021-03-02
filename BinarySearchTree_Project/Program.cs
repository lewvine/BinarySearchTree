using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a BinarySearchTree class to represent the Binary Search Tree data structure.You will also need to
            //create a Node class to represent the individual nodes that make up a binary search tree.
            //(5 points) As a developer, I want to create an ‘Add()’ method in my BinarySearchTree class to allow the
            //adding of a new node(with data) to the binary search tree data structure.
            //(5 points) As a developer, I want to create a ‘Search()’ method in my BinarySearchTree class to allow the
            //ability to search for a specific value within the binary search tree data structure.
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(12);

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);

            tree.Search(12);

        }
    }
}
