﻿namespace BusinessLogic.Car.DataModels
{
    using System.Threading.Tasks;

    public class Car : CarAbstract
    {
        private float fuel = 0f;

        public Car()
        {
            AddFuel();
        }

        public void AddFuel()
        {
            fuel = 20f;
        }

        public override bool GetEngineState()
        {
            if(fuel != 0)
            {
                return base.GetEngineState();
            }

            return false;
        }

        protected override async Task<bool> EngineRunning()
        {
            while(fuel != 0f)
            {
                fuel -= 0.5f;
                await Task.Delay(100);
            }

            isEngineRunning = false;
            return isEngineRunning;
        }
    }
}
