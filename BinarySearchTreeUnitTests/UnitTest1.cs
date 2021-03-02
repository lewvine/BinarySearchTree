﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BinarySearchTree_Project;

namespace BinarySearchTreeUnitTests
{
    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void Add_To_Empty_Tree_Expect_Node1_To_Be_Parent_Node()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(8);
            Node node3 = new Node(12);

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);

            int actual;
            int expected = 10;

            //Act
            actual = tree.ParentNode.data;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Expect_node2_To_Be_childLess_of_node1()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(8);
            Node node3 = new Node(12);

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);

            int actual;
            int expected = 8;

            //Act
            actual = tree.ParentNode.childLess.data;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Expect_node3_To_Be_childMore_of_node1()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(8);
            Node node3 = new Node(12);

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);

            int actual;
            int expected = 12;

            //Act
            actual = tree.ParentNode.childMore.data;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Expect_Node4ChildMore_ToBe_Node3_AND_Node1ChildLess_ToBe_Null()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(12);
            Node node3 = new Node(20);
            Node node4 = new Node(22);

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);

            int actual;
            int expected = 22;
            Node actual2;
            Node expected2 = null;

            //Act
            actual = tree.ParentNode.childMore.childMore.childMore.data;
            actual2 = tree.ParentNode.childLess;
            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
