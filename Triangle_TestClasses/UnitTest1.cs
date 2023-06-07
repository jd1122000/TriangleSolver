using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TriangleSolver;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Triangle_TestClasses
{
    [TestFixture]
    public class TestsForEQUILATERAL
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


    [TestFixture]
    public class TestForISOSCELES
    {
        [Test]
        public void ValideTringle_InputTest_1_ForIsosceles()
        {
            //Arragne
            int firstAngle = 50;
            int secondAngle = 50;
            int thirdAngle = 80;


            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValideTringle_InputTest_2_ForIsosceles()
        {
            //Arragne
            int firstAngle = 70;
            int secondAngle = 55;
            int thirdAngle = 55;


            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValideTringle_InputTest_3_ForIsosceles()
        {
            //Arragne
            int firstAngle = 56;
            int secondAngle = 68;
            int thirdAngle = 56;


            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }

    [TestFixture]
    public class TestsForSCALANE
    {
        [Test]
        public void ValideTringle_InputTest1_ForScalane()
        {
            //Arragne
            int firstAngle = 70;
            int secondAngle = 60;
            int thirdAngle = 50;


            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void ValideTringle_InputTest2_ForScalane()
        {
            //Arragne
            int firstAngle = 60;
            int secondAngle = 65;
            int thirdAngle = 55;


            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }




}


