namespace BusinessLogic.UnitTests.Player
{
    using BusinessLogic.Car.DataModels;
    using BusinessLogic.Player.DataModels;
    using Moq;
    using Xunit;

    public class PlayerTests
    {
        [Fact]
        public void CanCreateNewPlayer()
        {
            var player = new Player();
            Assert.NotNull(player);
        }

        [Fact]
        public void CanGetPlayerCar()
        {
            var fakeCar = new Mock<ICar>();
            var player = new Player(fakeCar.Object);
            Assert.NotNull(player.GetCar());
        }

        [Fact]
        public void PlayersCarIsRunning()
        {
            var player = new Player();
            Assert.True(player.IsPlayersCarRunning());
        }

        [Fact]
        public void PlayerCanHaveAnyCar()
        {
            var fakeCar = new Mock<ICar>();
            var player = new Player(fakeCar.Object);
            Assert.NotNull(player);
        }
    }
}
