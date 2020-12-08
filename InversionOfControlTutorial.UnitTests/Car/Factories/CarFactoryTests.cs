namespace BusinessLogic.UnitTests.Car.Factories
{
    using BusinessLogic.Car.Factories;
    using Xunit;

    public class CarFactoryTests
    {
        [Fact]
        public void CanCreateCar()
        {
            var car = CarFactory.CreateNewCar();
            Assert.NotNull(car);
        }
    }
}
