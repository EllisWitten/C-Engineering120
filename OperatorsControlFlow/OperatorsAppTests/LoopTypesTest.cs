using OperatorsControlFlow;

namespace OperatorsAppTests
{
    public class test1
    {

        [Test]

        public void GivenList_ForEachLoopReturn_HighestNumber()
        {
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };
            int highestNumber = -3;

            Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(highestNumber));
        }
        [Test]

        public void GivenNoList_ForEachLoopReturn_expectedResult()
        {
            List<int> nums = new List<int> { };

            Assert.That(LoopTypes.HighestForEachLoop(nums), Throws.ArgumentException();
        }








        [Test]

        public void GivenList_ForLoopReturn_HighestNumber()
        {
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };
            int highestNumber = -3;

            Assert.That(LoopTypes.HighestForLoop(nums), Is.EqualTo(highestNumber));
        }
        public void GivenNoList_ForLoopReturn_expectedResult()
        {
            List<int> nums = new List<int> { };
            int expectedResult = 0;

            Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(expectedResult));
        }





        [Test]

        public void GivenList_WhileLoopReturn_HighestNumber()
        {
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };
            int highestNumber = -3;

            Assert.That(LoopTypes.HighestWhileLoop(nums), Is.EqualTo(highestNumber));
        }

        [Test]

        public void GivenList_DoWhileLoopReturn_HighestNumber()
        {
            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };
            int highestNumber = -3;

            Assert.That(LoopTypes.HighestDoWhileLoop(nums), Is.EqualTo(highestNumber));
        }
    }
}
