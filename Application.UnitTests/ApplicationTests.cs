﻿namespace ApplicationCar.UnitTests
{
    using ApplicationCar;
    using BusinessLogic.Car.DataModels;
    using Xunit;

    public class ApplicationTests
    {
        public ApplicationTests()
        {
            Program.Setup();
        }

        [Fact]
        public void CanCreateCar()
        {
            var car = Program.GetCar();
            Assert.NotNull(car);
        }

        [Fact]
        public void CanCreatePlayer()
        {
            var player = Program.GetPlayer();
            Assert.NotNull(player);
        }

        [Fact]
        public void PlayersCarIsRunning()
        {
            var player = Program.GetPlayer();
            Assert.True(player.IsPlayersCarRunning());
        }

        [Fact]
        public void PlayerHasCar()
        {
            var player = Program.GetPlayer();
            var car = player.GetCar();

            Assert.IsType<Car>(car);
        }
    }
}
