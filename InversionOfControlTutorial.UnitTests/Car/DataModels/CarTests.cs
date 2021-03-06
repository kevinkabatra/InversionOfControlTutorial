﻿namespace BusinessLogic.UnitTests.Car.DataModels
{
    using BusinessLogic.Car.DataModels;
    using System.Threading.Tasks;
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

        [Fact]
        public void CanRunOutOfFuel()
        {
            var car = new Car();
            car.StartEngine();
            
            while(car.GetEngineState() == true)
            {
                // wait for fuel to burn
                Task.Delay(1000);
            }

            Assert.False(car.GetEngineState());
        }
    }
}
