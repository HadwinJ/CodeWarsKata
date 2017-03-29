using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeakNumbers.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class myjinxin
    {

        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual(new int[] { 2, 2 }, kata.WeakNumbers(9));

            Assert.AreEqual(new int[] { 0, 1 }, kata.WeakNumbers(1));

            Assert.AreEqual(new int[] { 0, 2 }, kata.WeakNumbers(2));

            Assert.AreEqual(new int[] { 2, 1 }, kata.WeakNumbers(7));

            Assert.AreEqual(new int[] { 403, 1 }, kata.WeakNumbers(500));

            Assert.AreEqual(new int[] { 0, 4 }, kata.WeakNumbers(4));


        }
    }
}
