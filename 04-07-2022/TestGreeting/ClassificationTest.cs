using CodeToTest;

namespace TestGreeting
{
    public class ClassificationTest
    {
        [TestCase(20, "All films are available!")]
        [TestCase(18, "All films are available!")]
        [TestCase(17, "Films U, PG, 12A, 12 and 15 are available!")]
        [TestCase(15, "Films U, PG, 12A, 12 and 15 are available!")]
        [TestCase(14, "Films U, PG, 12A and 12 are available!")]
        [TestCase(12, "Films U, PG, 12A and 12 are available!")]
        [TestCase(8, "Films U and PG are available!")]

        public void GivenAgeOfViewer_AvailableClassifications_returnsCorrespondingRatings(int ageOfViewer, string expectedResults)
        {
            Assert.That(Program.AvailableClassifications(ageOfViewer), Is.EqualTo(expectedResults));
        }
    }
}