namespace ApplicationElectricCar.UnitTests.Car.DataModel
{
    using ApplicationElectricCar.Car.DataModel;
    using System.Threading.Tasks;
    using Xunit;

    public class ElectricCarTests
    {
        [Fact]
        public void CanCreateCar()
        {
            var car = new ElectricCar();
            Assert.NotNull(car);
        }

        [Fact]
        public void NewCarIsNotRunning()
        {
            var car = new ElectricCar();
            Assert.False(car.GetEngineState());
        }

        [Fact]
        public void CanStartCar()
        {
            var car = new ElectricCar();
            car.StartEngine();
            Assert.True(car.GetEngineState());
        }

        [Fact]
        public void CanRunOutOfPower()
        {
            var car = new ElectricCar();
            car.StartEngine();

            while (car.GetEngineState() == true)
            {
                // wait for fuel to burn
                Task.Delay(1000);
            }

            Assert.False(car.GetEngineState());
        }
    }
}
