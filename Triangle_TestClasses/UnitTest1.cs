using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TriangleSolver;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Triangle_TestClasses
{
    [TestFixture]
    public class Tests_For_EQUILATERAL
    {
        [Test]
        public void ValideTringle_InputTestForEquilateral()
        {
            //Arragne
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;


            string expected = "An EQUILATERAL triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }

   

}


