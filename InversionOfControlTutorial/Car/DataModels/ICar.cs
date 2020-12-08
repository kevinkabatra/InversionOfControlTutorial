namespace InversionOfControlTutorial.Car.DataModels
{
    public interface ICar
    {
        /// <summary>
        ///     Determines the state that the engine is in.
        /// </summary>
        /// <returns></returns>
        bool GetEngineState();

        /// <summary>
        ///     Starts the engine.
        /// </summary>
        void StartEngine();
    }
}
