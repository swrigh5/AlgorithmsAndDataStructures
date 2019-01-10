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
        private DynamicArray<String> array;

        [SetUp]
        public void SetUp()
        {
            array = new DynamicArray<String>(2);
           
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
            array.add("Stephen");
            array.add("Michael");
            array.add("Wright");
    

            array.insert(2, "Is");

            Assert.That(array.Get(0), Is.EqualTo("Stephen"));
            Assert.That(array.Get(1), Is.EqualTo("Michael"));
            Assert.That(array.Get(2), Is.EqualTo("Is"));
            Assert.That(array.Get(3), Is.EqualTo("Wright"));
        }


        [Test]
        public void delete()
        {
            array.add("Stephen");
            array.add("Michael");
            array.add("Wright");

            array.delete(1);

            Assert.That(array.Get(0), Is.EqualTo("Stephen"));
            Assert.That(array.Get(1), Is.EqualTo("Wright"));
        }


        [Test]
        public void IsEmpty()
        {
            Assert.That(array.isEmpty(), Is.True);
        }

        [Test]
        public void IsEmptyReturnsFalse()
        {
            array.add("Stephen");
            array.add("Wright");

            array.delete(1);

            Assert.That(array.isEmpty(), Is.False);

        }


        [Test]
        public void ContainsReturnTrue()
        {
            array.add("Stephen");
            array.add("Wright");

            Assert.That(array.Contains("Wright"), Is.True);
        }
        
        [Test]
        public void ContainsReturnsFalse()
        {
            array.add("Stephen");
            array.add("Wright");

            Assert.That(array.Contains("Michael"), Is.False);
        }



    }
}
