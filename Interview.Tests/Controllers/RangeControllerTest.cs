using Interview.Controllers;
using NUnit.Framework;
using System.Collections;
using System.Web.Mvc;

namespace Interview.Tests.Controllers
{
    [TestFixture]
    public class RangeControllerTest
    {
        [Test]
        [TestCase(null, 22)]
        [TestCase("BMW", 22)]
        [TestCase("Audi", 20)]
        [TestCase("Ford", 15)]
        public void List(string name, int expectedNumber)
        {
            var controller = new RangeController();
            var result = controller.List(name) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedNumber, (result.Model as IList).Count);
        }
    }
}
