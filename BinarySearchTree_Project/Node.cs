using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_Project
{
    class Node
    {
        public int data;
        public int count;
        public Node childLess;
        public Node childMore;

        public Node(int data)
        {
            this.data = data;
        }

    }
}
