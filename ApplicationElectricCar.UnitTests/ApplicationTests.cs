namespace ApplicationElectricCar.UnitTests
{
    using ApplicationElectricCar;
    using ApplicationElectricCar.Car.DataModel;
    using Xunit;

    public class ApplicationTests
    {
        public ApplicationTests()
        {
            Program.Setup();
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
        public void PlayerHasElectricCar()
        {
            var player = Program.GetPlayer();
            var car = player.GetCar();

            Assert.IsType<ElectricCar>(car);
        }
    }
}
