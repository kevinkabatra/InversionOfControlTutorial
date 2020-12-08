namespace BusinessLogic.Car.Factories
{
    using Car.DataModels;

    public class CarFactory
    {
        /// <summary>
        ///     Creates a new Car.
        /// </summary>
        /// <returns></returns>
        public static ICar CreateNewCar()
        {
            return new Car();
        }
    }
}
