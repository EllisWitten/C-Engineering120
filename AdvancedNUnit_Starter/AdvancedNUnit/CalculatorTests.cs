using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { 
            
               

        }

        [Category("Happy Path")]
        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void SomeConstraints()
        {
            var _sut = new Calculator { Num1 = 6 };
            Assert.That(_sut.DivisibleBy3());

            _sut.Num1 = 7;
            Assert.That(_sut.DivisibleBy3(), Is.False);
        }

        [Test]

        public void StringContraints()
        {
            var _subject = new Calculator() { Num1 = 2, Num2 = 4 };
            var strResult = _subject.ToString();

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));

            Assert.That(strResult, Does.Contain("Calculator"));

            Assert.That(strResult, Does.Not.Contain("Potato"));

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator").IgnoreCase);

        }

        [Test]

        public void TestArrayOfString()
        {
            var fruit = new List<string> { "apple", "pear", "bannana", "grape" };

            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Does.Not.Contain("kiwi"));
            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Exactly(1).StartsWith("pea"));


        }

        [Test]

        public void TestRanges()
        {
            Assert.That(8, Is.InRange(1, 10));

            List<int> nums = new List<int> { 4, 2, 7, 5, 9 };

            Assert.That(nums, Is.All.InRange(1, 10));
            Assert.That(nums, Has.Exactly(3).InRange(2, 5));
            
        }

        [Category("Sad Path")]
        [TestCase(5,0)]

        public void GivenNum2As0_CalculaterDivivde_ThrowsError(double inp1, double inp2)
        {
            var divisable = new Calculator { Num1 = inp1, Num2 = inp2 };
            Assert.That(() => divisable.Divide(), Throws.TypeOf<ArgumentException>());
        }

    }

}