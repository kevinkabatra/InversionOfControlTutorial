namespace BusinessLogic.Player.DataModels
{
    using Car.DataModels;
    using Car.Factories;

    public class Player
    {
        private readonly ICar _car;

        /// <summary>
        ///     Constructor.
        /// </summary>
        public Player()
        {
            _car = CarFactory.CreateNewCar();
            _car.StartEngine();
        }

        /// <summary>
        ///     Constructor injection.
        /// </summary>
        /// <param name="car"></param>
        public Player(ICar car)
        {
            _car = car;
            _car.StartEngine();
        }

        /// <summary>
        ///     Determines if the player's car is currently running.
        /// </summary>
        /// <returns></returns>
        public bool IsPlayersCarRunning()
        {
            return _car.GetEngineState();
        }
    }
}
