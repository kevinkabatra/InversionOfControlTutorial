namespace BusinessLogic.UnitTests.Car.DataModels
{
    using BusinessLogic.Car.DataModels;
    using Xunit;

    public class CarTests
    {
        [Fact]
        public void CanCreateCar()
        {
            var car = new Car();
            Assert.NotNull(car);
        }

        [Fact]
        public void NewCarIsNotRunning()
        {
            var car = new Car();
            Assert.False(car.GetEngineState());
        }

        [Fact]
        public void CanStartCar()
        {
            var car = new Car();
            car.StartEngine();
            Assert.True(car.GetEngineState());
        }
    }
}
