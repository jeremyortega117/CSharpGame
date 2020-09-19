using AlgorithmLibrary;
using Entities;
using System;
using Xunit;

namespace AlgorithmTests
{
    public class MergeSortTest
    {
        [Fact]
        public void MergeSortNine()
        {

            Node[] nodes = new Node[]{ new Node(1) {xVal = 100.4, yVal = 100.4},
                             new Node(2) {xVal = 105.4, yVal = 98.3},
                             new Node(3) {xVal = 97.4, yVal = 42.3},
                             new Node(4) {xVal = 84.4, yVal = 120.3},
                             new Node(5) {xVal = 106.8, yVal = 93.3},
                             new Node(6) {xVal = 109.1, yVal = 88.3},
                             new Node(7) {xVal = 58.4, yVal = 110.3},
                             new Node(8) {xVal = 77.9, yVal = 84.3},
                             new Node(9) {xVal = 60.4, yVal = 94.2},
                             new Node(10) {xVal = 101.4, yVal = 104.7},
                            };
            Assert.Equal(100.4, nodes[0].xVal);
            Assert.Equal(105.4, nodes[1].xVal);
            Assert.Equal(97.4, nodes[2].xVal);
            Assert.Equal(84.4, nodes[3].xVal);
            Assert.Equal(106.8, nodes[4].xVal);
            Assert.Equal(109.1, nodes[5].xVal);
            Assert.Equal(58.4, nodes[6].xVal);
            Assert.Equal(77.9, nodes[7].xVal);
            Assert.Equal(60.4, nodes[8].xVal);
            Assert.Equal(101.4, nodes[9].xVal);


            MergeSort mergeSort = new MergeSort();
            mergeSort.sort(nodes, 0, 9);

            //Console.WriteLine("\nAFTER SORT:");
            //printNodesLeftToRight(nodes);

            Assert.Equal(58.4, nodes[0].xVal);
            Assert.Equal(60.4, nodes[1].xVal);
            Assert.Equal(77.9, nodes[2].xVal);
            Assert.Equal(84.4, nodes[3].xVal);
            Assert.Equal(97.4, nodes[4].xVal);
            Assert.Equal(100.4, nodes[5].xVal);
            Assert.Equal(101.4, nodes[6].xVal);
            Assert.Equal(105.4, nodes[7].xVal);
            Assert.Equal(106.8, nodes[8].xVal);
            Assert.Equal(109.1, nodes[9].xVal);



        }





        //public void printNodesLeftToRight(Node[] nodes)
        //{
        //    foreach (Node node in nodes)
        //    {
        //        Console.WriteLine(node.xVal);
        //    }
        //}
    }
}
