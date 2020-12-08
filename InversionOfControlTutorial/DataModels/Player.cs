namespace InversionOfControlTutorial.DataModels
{
    public class Player
    {
        private Car _car;

        /// <summary>
        ///     Constructor.
        /// </summary>
        public Player()
        {
            _car = new Car();
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
