namespace FizzBuzzApp;

public class FizzBuzzTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenOne_Retrun_OneString()
    {
        Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
    }
    [Test]
    public void GivenTwo_Retrun_TwoString()
    {
        Assert.That(Program.FizzBuzz(2), Is.EqualTo("2"));
    }
}