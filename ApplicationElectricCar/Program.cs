namespace ApplicationElectricCar
{
    using Autofac;
    using BusinessLogic.Car.DataModels;
    using BusinessLogic.Player.DataModels;
    using Car.DataModel;
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
            using var scope = Container.BeginLifetimeScope();
            var player = scope.Resolve<Player>();

            return player;
        }

        /// <summary>
        ///     Sets up the Autofac container.
        /// </summary>
        /// <remarks>
        ///     The builder allows us to register types for the container to hold.
        ///     Here we are register the:
        ///         1. Car to be exposed through its interface, you can refer to GetCar to see how to retrieve the new object.
        ///         2. Player to be exposed through itself, you can refer to GetPlayer to see how to retrieve the new object.
        /// </remarks>
        public static void Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ElectricCar>().As<ICar>();
            builder.RegisterType<Player>().AsSelf();

            Container = builder.Build();
        }

        /// <summary>
        ///     The application.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Setup();
            var player = GetPlayer(); // can use container to auto-magically inject dependancies - it knows how to resolve both
            Console.WriteLine(String.Format("Is car running: {0}", player.IsPlayersCarRunning()));
        }
    }
}
