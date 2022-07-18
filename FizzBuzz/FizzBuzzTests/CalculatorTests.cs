namespace CalculatorApp;

public class CalculatorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("", 0)]
    [TestCase("1", 1)]
    [TestCase("1,2", 3)]

    public void GivenValues_Add_ReturnsExpectedResult(string input,int expectedResult)
    {
        Assert.That(Program.Add(input), Is.EqualTo(expectedResult));
    }
    
}