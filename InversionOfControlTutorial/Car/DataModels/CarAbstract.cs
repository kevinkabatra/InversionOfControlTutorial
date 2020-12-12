namespace BusinessLogic.Car.DataModels
{
    using System.Threading.Tasks;

    public abstract class CarAbstract : ICar
    {
        protected bool isEngineRunning = false;

        /// <inheritdoc/>
        public virtual bool GetEngineState()
        {
            return isEngineRunning;
        }

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "I do not want the StartEngine to be hung by the engine running.")]
        public virtual void StartEngine()
        {
            isEngineRunning = true;
            var noNeedToWaitForEngineToStopRunningToFinishStartingEngine = EngineRunning();
        }

        /// <summary>
        ///     Consumes what the Car is using for fuel.
        /// </summary>
        /// <returns></returns>
        protected abstract Task<bool> EngineRunning();
    }
}
