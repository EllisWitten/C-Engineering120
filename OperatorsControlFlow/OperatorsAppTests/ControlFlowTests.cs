using OperatorsControlFlow;

namespace OperatorsAppTests
{
    public class test
    {
        [TestCase(90, "Distinction")]
        [TestCase(85, "Distinction")]

        [TestCase(70, "Pass")]
        [TestCase(68, "Pass")]
        [TestCase(65, "Pass")]

        [TestCase(60, "Fail")]
        [TestCase(50, "Fail")]

        public void Given_GradeInput_ReturnExpectedResult(int gradeInput, string expectedResult)
        {
            Assert.That(Selection.Grade(gradeInput), Is.EqualTo(expectedResult));
        }
    }
}
