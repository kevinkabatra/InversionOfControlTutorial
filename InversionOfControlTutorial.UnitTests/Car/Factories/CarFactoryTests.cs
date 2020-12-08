namespace InversionOfControlTutorial.UnitTests.Car.Factories
{
    using InversionOfControlTutorial.Car.Factories;
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
