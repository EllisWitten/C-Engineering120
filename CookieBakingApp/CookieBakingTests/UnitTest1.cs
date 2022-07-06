using CookieBakingApp;
namespace CookieBakingTests
{
    public class Tests
    {
        [Test]
        public void GivenRecipie_Returns_RecipieMessage()
        {
            //Arrange
            string message = Baker.RecipeMessage();
            string expectedMessage = "Are you sure its right?";

            Assert.That(message, Is.EqualTo(expectedMessage));
        }
    }
}