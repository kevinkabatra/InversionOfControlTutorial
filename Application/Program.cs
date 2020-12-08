namespace Application
{
    using Autofac;
    using BusinessLogic.Car.DataModels;
    using BusinessLogic.Car.Factories;
    using BusinessLogic.Player.DataModels;
    using System;

    public class Program
    {
        private static IContainer Container { get; set; }
        
        /// <summary>
        ///     Gets the player object.
        /// </summary>
        /// <returns></returns>
        public static Player GetPlayer()
        {
            var player = new Player(GetCar());
            return player;
        }

        /// <summary>
        ///     Gets the car object.
        /// </summary>
        /// <returns></returns>
        public static ICar GetCar()
        {
            using var scope = Container.BeginLifetimeScope();

            var car = scope.Resolve<ICar>();
            return car;
        }

        /// <summary>
        ///     Sets up the Autofac container.
        /// </summary>
        public static void Setup()
        {
            // Create the builder
            var builder = new ContainerBuilder();

            // Expose the Car through its interface
            // Note: You can register multiple types prior to build the container.
            builder.RegisterType<Car>().As<ICar>();
            builder.RegisterType<CarFactory>().AsSelf();

            // Build the inversion of control container
            Container = builder.Build();
        }

        /// <summary>
        ///     The application.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Setup();
            var player = GetPlayer();
            Console.WriteLine(String.Format("Is car running: {0}", player.IsPlayersCarRunning()));
        }
    }
}
