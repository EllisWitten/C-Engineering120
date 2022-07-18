using DrivingLab;
namespace VehicleTests
{
    public class Tests
    {

        [Test]
        public void GivenDefaultValues_MethodMove_RetrunsCorrectValue()
        {
            Vehicle v = new Vehicle(5);
            v.Move();
            int position = v.Position;
            int expectedPosition = 10;
            Assert.That(position, Is.EqualTo(expectedPosition));
        }

        [TestCase(30, 30)]
        [TestCase(45, 45)]
        [TestCase(50, 50)]

        public void GivenASpeedAndNoTimes_MethodMove_ReturnsCorrectValue(int speed, int expectedPosition)
        {
            Vehicle v = new Vehicle(5, speed);
            v.Move();
            int position = v.Position;
            Assert.That(position, Is.EqualTo(expectedPosition));
        }
    }
}