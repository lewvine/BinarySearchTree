using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BinarySearchTree_Project;

namespace BinarySearchTreeUnitTests
{
    [TestClass]
    public class SearchUnitTests
    {
        [TestMethod]
        public void Search_Empty_Tree_Expect_False()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();

            bool actual;
            bool expected = false;

            //Act
            actual = tree.Search(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_One_Item_Tree_Expect_True()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            tree.Add(node1);

            bool actual;
            bool expected = true;

            //Act
            actual = tree.Search(10);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_One_Item_Tree_Expect_False()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            tree.Add(node1);

            bool actual;
            bool expected = false;

            //Act
            actual = tree.Search(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_Tree_Item_Tree_Expect_False()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(12);
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);


            bool actual;
            bool expected = false;

            //Act
            actual = tree.Search(3);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_Three_Item_Tree_Expect_True()
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(10);
            Node node2 = new Node(5);
            Node node3 = new Node(12);
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);


            bool actual;
            bool expected = true;

            //Act
            actual = tree.Search(12);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
