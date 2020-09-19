using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmLibrary;
using Xunit;
using Entities;

namespace AlgorithmTests
{
    public class DblLinkedListTest
    {
        [Fact]
        public void DblLinkedList9()
        {

            Node node = new Node(1);
            node.xVal = 1;
            node.yVal = 2;
            DblLinkedList dll = new DblLinkedList(node);


            Node node2 = new Node(2);
            node2.xVal = 3;
            node2.yVal = 4;
            DblLinkedList dll2 = new DblLinkedList(node2);

            dll.setNext(dll2);
            dll2.setPrev(dll);

            Assert.Equal(1, dll.getNode().xVal);
            Assert.Equal(3, dll2.getNode().xVal);
            Assert.Equal(1, dll2.getPrev().getNode().xVal);
            Assert.Equal(3, dll.getNext().getNode().xVal);

        }
    }
}
