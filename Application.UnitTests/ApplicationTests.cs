namespace Application.UnitTests
{
    using Application;
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
    }
}
