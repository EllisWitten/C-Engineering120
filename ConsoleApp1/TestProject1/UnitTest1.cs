namespace PalindromeNUnit;

public class Tests
{
    [SetUp] 
    public void SetUp()
    {

    }

    [TestCase("rotor")]
    [TestCase("215696512")]

    public void GivenAPalindromeString_PalindromeVar_ReturnsExpectedResult(string input)
    {
        Assert.That(Palindrome.PalindromeVar(input), Is.EqualTo($"True, {input} is a palindrome"));
    }

    [TestCase("cows")]
    [TestCase("15678")]

    public void GivenANonPalindromeString_PalindromeVar_ReturnsExpectedResult(string input)
    {
        Assert.That(Palindrome.PalindromeVar(input), Is.EqualTo($"False, {input} is not a palindrome: {Palindrome.ReverseString(input)}"));
    }

    [TestCase("rotor")]
    [TestCase("46564")]

    public void CheckThatAllInputCharacters_GivenToPalindromeVar_AreInReturnValue(string input)
    {
        Assert.That(Palindrome.PalindromeVar(input).Contains(input));
    }

    [TestCase("-1-2-3-2-1")]
    [TestCase("-1")]

    public void GivenANegativeListWithNoCommas_PalindromeVar_ThrowsError(string input)
    {
        Assert.Throws(Is.TypeOf<ArgumentException>().And.Message.EqualTo("a negative list must be seperated by commas"),() => Palindrome.PalindromeVar(input));
    }

    [Test]

    public void GivenANegativePalindromListSeperatedByCommas_PalindromeVar_ReturnsTrue()
    {
        Assert.That(Palindrome.PalindromeVar("-1,-2,-3,-2,-1"), Is.EqualTo("True, -1,-2,-3,-2,-1 is a palindrome"));
    }
}