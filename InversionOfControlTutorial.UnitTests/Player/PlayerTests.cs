namespace InversionOfControlTutorial.UnitTests.Player
{
    using InversionOfControlTutorial.Player.DataModels;
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
        public void PlayersCarIsRunning()
        {
            var player = new Player();
            Assert.True(player.IsPlayersCarRunning());
        }
    }
}
