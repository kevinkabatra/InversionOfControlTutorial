namespace BusinessLogic.Car.DataModels
{
    public class Car : ICar
    {
        private bool isEngineRunning = false;

        /// <inheritdoc/>
        public bool GetEngineState()
        {
            return isEngineRunning;
        }

        /// <inheritdoc/>
        public void StartEngine()
        {
            isEngineRunning = true;
        }
    }
}
