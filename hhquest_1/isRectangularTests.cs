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
    public class isRectangularTests
    {
        [TestMethod()]
        public void isRectangularBoolTest()
        {
            
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            isRectangular isRectangular = new isRectangular();
            bool actual = isRectangular.isRectangularBool(a, b, c);      
                       
            Assert.AreEqual(expected, actual);
        }
    }
}