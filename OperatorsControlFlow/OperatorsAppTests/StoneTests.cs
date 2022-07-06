using OperatorsControlFlow;


namespace OperatorsAppTests
{
    public class Tests
    {

        [TestCase(14,1)]
        [TestCase(27, 1)]
        [TestCase(48, 3)]
        public void Test1(int poundsInput, int expectedResult)
        {
            Assert.That(Methods.GetStones(poundsInput), Is.EqualTo(expectedResult));
        }

        [TestCase(14, 0)]
        [TestCase(27, 13)]
        [TestCase(48, 6)]
        public void Test2(int poundsInput, int expectedResult)
        {
            Assert.That(Methods.GetPounds(poundsInput), Is.EqualTo(expectedResult));
        }
    }
}