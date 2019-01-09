using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AlgorithmsAndDataStructures
{
    [TestFixture]
    class ArrayTests
    {
        private DynamicArray array;

        [SetUp]
        public void SetUp()
        {
            array = new DynamicArray(2);
           
        }


        [Test]
        public void GetAndSet()
        {
            array.Set(0, "a");
            Assert.That(array.Get(0), Is.EqualTo("a"));
        }


        [Test]
        public void insert()
        {
            array.Set(0, "Stephen");
            array.Set(1, "Kyle");

            array.insert(1, "Matt");

            Assert.That(array.Get(0), Is.EqualTo("Stephen"));
            Assert.That(array.Get(1), Is.EqualTo("Matt"));
            Assert.That(array.Get(2), Is.EqualTo("Kyle"));
        }
    }
}
