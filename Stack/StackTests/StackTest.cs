using NUnit.Framework;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTests
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Creation()
        {
            CustomStack<int> s = new CustomStack<int>(3);
            Assert.AreEqual(0, s.Size);
        }
        [Test]
        public void Push_TakesAnArgumentAndPushesItToTheTopOfTheStack()
        {
            CustomStack<int> s = new CustomStack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);

            int value = s.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Size);
        }

        [Test]
        public void PushNewElements_WhenStackIsFull_throwsException()
        {
            CustomStack<int> s = new CustomStack<int>(0);
            Assert.Throws<PushingAfterLimitException>(() => s.Push(1));
        }

        [Test]
        public void Pop_WhenStackIsEmpty_throwsException()
        {
            CustomStack<int> s = new CustomStack<int>(3);
            Assert.Throws<NothingToPopException>(() => s.Pop());
        }
    }
}
