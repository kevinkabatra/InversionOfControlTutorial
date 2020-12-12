namespace ApplicationElectricCar.Car.DataModel
{
    using BusinessLogic.Car.DataModels;
    using System.Threading.Tasks;

    public class ElectricCar : CarAbstract
    {
        private float batteryPercentage = 0f;

        public ElectricCar()
        {
            ChargeBattery();
        }

        public void ChargeBattery()
        {
            batteryPercentage = 100f;
        }

        public override bool GetEngineState()
        {
            if(batteryPercentage != 0)
            {
                return base.GetEngineState();
            }

            return false;
        }

        protected override async Task<bool> EngineRunning()
        {
            while(batteryPercentage != 0f)
            {
                batteryPercentage -= 2.5f;
                await Task.Delay(100);
            }

            isEngineRunning = false;
            return isEngineRunning;
        }
    }
}
