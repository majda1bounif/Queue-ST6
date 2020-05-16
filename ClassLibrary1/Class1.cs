using NUnit.Framework;
using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        [Test()]
        public void EnqueueTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            string s = "";
            foreach (var i in q)
                s += i.ToString();
            string expected = "123";
            Assert.AreEqual(s, expected);
        }
        [Test()]
        public void DequeueTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Dequeue();
            string s = "";
            foreach (var i in q)
                s += i.ToString();
            string expected = "23";
            Assert.AreEqual(s, expected);
        }
        [Test()]
        public void FirstPassTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            int actual = q.First;
            int expected = 1;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void FirstExcTest()
        {
            QueueL<int> q = new QueueL<int>();
            int actual;
            Assert.Throws<InvalidOperationException>(
                () => { actual = q.First(); });

        }
        [Test()]
        public void LastPassTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            int actual = q.Last;
            int expected = 3;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void LastExcTest()
        {
            QueueL<int> q = new QueueL<int>();
            int actual;
            //string actual;
            Assert.Throws<InvalidOperationException>(
                () => { actual = q.Last(); });

        }
        [Test()]
        public void CountTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            int actual = q.Count;
            int expected = 3;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        public void IsEmptyTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            bool actual = q.IsEmpty;
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }
        public void ClearTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Clear();
            int actual = q.Count;
            int expected = 0;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        public void ContainsTest()
        {
            QueueL<int> q = new QueueL<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            bool actual = q.Contains(5);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void DequeueExcTest()
        {
            QueueL<int> q = new QueueL<int>();
            int actual;
            //string actual;
            Assert.Throws<InvalidOperationException>(
                () => { actual = q.Dequeue(); });
            //QueueL<int> q = new QueueL<int>();
            //q.Dequeue();
        }
    }
}