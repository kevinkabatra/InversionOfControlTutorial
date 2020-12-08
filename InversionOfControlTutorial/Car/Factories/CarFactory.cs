namespace InversionOfControlTutorial.Car.Factories
{
    using Car.DataModels;

    public class CarFactory
    {
        /// <summary>
        ///     Creates a new Car.
        /// </summary>
        /// <returns></returns>
        public static Car CreateNewCar()
        {
            return new Car();
        }
    }
}
