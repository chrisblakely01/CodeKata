using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DigitalRoute
{

    [TestFixture]
    public class NumberTest
    {
        private Number num;

        [SetUp]
        public void SetUp()
        {
            num = new Number();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
            Assert.AreEqual(6, num.DigitalRoot(942));
            Assert.AreEqual(6, num.DigitalRoot(195));
            Assert.AreEqual(6, num.DigitalRoot(132189));
            Assert.AreEqual(2, num.DigitalRoot(493193));
        }
    }
}
