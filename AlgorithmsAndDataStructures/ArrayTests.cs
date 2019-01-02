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


    }
}
