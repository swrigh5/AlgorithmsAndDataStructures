using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgorithmsAndDataStructures.LinkedLists
{
    [TestFixture]
    class LinkedListTests
    {
        private LinkedList linkedList;

        [SetUp]
        public void setup()
        {
           linkedList = new LinkedList();
        }

        [Test]
        public void addFront()
        {
            linkedList.addFront(1);
            linkedList.addFront(2);
            linkedList.addFront(3);

            Assert.That(linkedList.getFirst(), Is.EqualTo(3));
            Assert.That(linkedList.getLast(), Is.EqualTo(1));
        }

        [Test]
        public void getFirst()
        {
            
        }

        [Test]
        public void getLast()
        {

        }



        [Test]
        public void addBack()
        {


        }

    }
}
