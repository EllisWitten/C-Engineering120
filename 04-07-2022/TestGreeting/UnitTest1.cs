using CodeToTest;

namespace TestGreeting;

public class Tests
{
    [TestCase(20, "Good evening!")]
    [TestCase(24, "Good evening!")]
    [TestCase(4, "Good evening!")]
    [TestCase(12, "Good afternoon!")]
    [TestCase(15, "Good afternoon!")]
    [TestCase(18, "Good afternoon!")]
    [TestCase(5, "Good morning!")]
    [TestCase(8, "Good morning!")]
    [TestCase(11, "Good morning!")]
    [TestCase(0, "Invalid Time")]
    [TestCase(-1, "Invalid Time")]
    [TestCase(25, "Invalid Time")]
    public void GivenATimeBetweeen1and24_Greeting_returnsGoodTOD(int time, string greet)
    {
        Assert.That(Program.Greeting(time), Is.EqualTo(greet));
    }
}