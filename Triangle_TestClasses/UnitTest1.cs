﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using TriangleSolver;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Triangle_TestClasses
{
    [TestFixture]
    public class TestsForEquilateral
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
    public class TestForIsosceles
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
    public class TestsForScalane
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
        [Test]
        public void ValideTringle_InputTest3_ForScalane()
        {
            //Arragne
            int firstAngle = 75;
            int secondAngle = 45;
            int thirdAngle = 60;


            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void ValideTringle_InputTest4_ForScalane()
        {
            //Arragne
            int firstAngle = 80;
            int secondAngle = 40;
            int thirdAngle = 60;


            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void ValideTringle_InputTest5_ForScalane()
        {
            //Arragne
            int firstAngle = 40;
            int secondAngle = 55;
            int thirdAngle = 85;


            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
    }


    [TestFixture]
    public class TestsForZeroLength
    {
        [Test]
        public void ValideTringle_InputTest1_ForZeroLength()
        {


            //Arragne
            int firstAngle = 40;
            int secondAngle = 0;
            int thirdAngle = 90;


            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void ValideTringle_InputTest2_ForZeroLength()
        {


            //Arragne
            int firstAngle = 0;
            int secondAngle = 180;
            int thirdAngle = 0;


            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void ValideTringle_InputTest3_ForZeroLength()
        {

            //Arragne
            int firstAngle = 100;
            int secondAngle = 80;
            int thirdAngle = 0;


            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);



        }
    }

    [TestFixture]
    public class TestsForInvalidResponse
    {
        [Test]
        public void ValideTringle_InputTest1_ForInvalidResponse()
        {
            //Arragne
            int firstAngle = 20;
            int secondAngle = 60;
            int thirdAngle = 10;


            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ValideTringle_InputTest2_ForInvalidResponse()
        {
            //Arragne
            int firstAngle = 30;
            int secondAngle = 50;
            int thirdAngle = 10;


            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ValideTringle_InputTest3_ForInvalidResponse()
        {
            //Arragne
            int firstAngle = 150;
            int secondAngle = 5;
            int thirdAngle = 10;


            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}



