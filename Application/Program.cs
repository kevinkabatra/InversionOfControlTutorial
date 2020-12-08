namespace Application
{
    using Autofac;
    using BusinessLogic.Car.DataModels;
    using BusinessLogic.Player.DataModels;
    using System;

    public class Program
    {
        private static IContainer Container { get; set; }
        
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

        /// <summary>
        ///     Gets the player object.
        /// </summary>
        /// <returns></returns>
        private static Player GetPlayer()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var car = scope.Resolve<ICar>();
                var player = new Player(car);
                
                return player;
            }
        }

        /// <summary>
        ///     Sets up the Autofac container.
        /// </summary>
        private static void Setup()
        {
            // Create the builder
            var builder = new ContainerBuilder();

            // Expose the Car through its interface
            // Note: You can register multiple types prior to build the container.
            builder.RegisterType<Car>().As<ICar>();

            // Build the inversion of control container
            Container = builder.Build();
        }
    }
}
