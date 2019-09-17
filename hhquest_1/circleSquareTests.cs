using Microsoft.VisualStudio.TestTools.UnitTesting;
using hhQuest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhQuest.Tests
{
    [TestClass()]
    public class circleSquareTests
    {
        [TestMethod()]
        public void circleTest()
        {
            double radius = 5;
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 3;

            circleSquare circleSquare = new circleSquare();

            double actual = circleSquare.circle(a, b, c, radius);

            Assert.AreEqual(expected, actual);
        }
    }
}