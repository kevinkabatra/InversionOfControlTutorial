namespace InversionOfControlTutorial.Car.DataModels
{
    public class Car
    {
        private bool isEngineRunning = false;

        /// <summary>
        ///     Determines the state that the engine is in.
        /// </summary>
        /// <returns></returns>
        public bool GetEngineState()
        {
            return isEngineRunning;
        }

        /// <summary>
        ///     Starts the engine.
        /// </summary>
        public void StartEngine()
        {
            isEngineRunning = true;
        }
    }
}
