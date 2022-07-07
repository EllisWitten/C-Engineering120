using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(1, 1)]
        [TestCase(4, 4)]
        [TestCase(108, 108)]
        [TestCase(-20, -20)]

        public void WhenGiven2IdenticalNumber_MyMethod_Returns_False(int num1, int num2)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(false));
        }

        [TestCase(5, 2)]
        [TestCase(9, 4)]
        [TestCase(108, 128)]
        [TestCase(-7, -20)]

        public void WhenGiven_TwoNumbersWhereTheFirstIsNotDivisableByTheSecond_ReturnFalse(int num1, int num2)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(false));
        }

        [TestCase(5, 1)]
        [TestCase(8, 4)]
        [TestCase(100, 10)]
        [TestCase(30, 3)]

        public void WhenGiven_TwoNumbersWhereTheFirstIsDivisableByTheSecond_ReturnTrue(int num1, int num2)
        {
            Assert.That(Exercises.MyMethod(num1, num2), Is.EqualTo(true));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() { };
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(110)]
        [TestCase(-1)]

        public void GradeOutOfRangeTest(int grade)
        {
            Assert.That(() => Exercises.Grade(grade), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [TestCase(100, "Pass with Distinction")]
        [TestCase(90, "Pass with Distinction")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(74, "Pass with Merit")]
        [TestCase(70, "Pass with Merit")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(59, "Pass")]
        [TestCase(50, "Pass")]
        [TestCase(40, "Pass")]
        [TestCase(39, "Fail")]
        [TestCase(20, "Fail")]

        public void GradeReturnsExpectedResult(int grade, string expectedResult)
        {
            Assert.That(Exercises.Grade(grade), Is.EqualTo(expectedResult));
        }

        [TestCase(0, 200)]
        [TestCase(1, 100)]
        [TestCase(2, 50)]
        [TestCase(3, 50)]
        [TestCase(4, 20)]

        public void CovidLevel_Returns_ExpectedResult(int covidLevel, int expectedResult)
        {
            Assert.That(Exercises.GetScottishMaxWeddingNumbers(covidLevel), Is.EqualTo(expectedResult));
        }

        [TestCase(5)]
        [TestCase(-1)]
        public void CovidLevelOutOfRange(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
