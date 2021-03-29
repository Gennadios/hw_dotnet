using System;
using System.Collections.Generic;
using Serilog;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            Log.Information($"{typeof(Program)} has started running");

            Motorcycle yamaha = new Motorcycle(123, "Yamaha", "y1", 2020, 15);
            Motorcycle suzuki = new Motorcycle(234, "Suzuki", "s1", 2021, 18);
            Motorcycle honda = new Motorcycle(345, "Honda", "h1", 2020, 2);
            Motorcycle kawasaki = new Motorcycle(456, "Kawasaki", "k1", 2021, 3);
            Motorcycle ducatti = new Motorcycle(567, "Ducatti", "d1", 2020, 6);
            Motorcycle ural = new Motorcycle(678, "Ural", "u1", 1989, 100);

            MotoRepository motorepo = new MotoRepository();

            #region Create
            Console.WriteLine("Adding motos to collection: ");
            motorepo.CreateMotorcycle(yamaha);
            motorepo.CreateMotorcycle(suzuki);
            motorepo.CreateMotorcycle(honda);
            motorepo.CreateMotorcycle(kawasaki);
            motorepo.CreateMotorcycle(ducatti);
            motorepo.CreateMotorcycle(ural);

            motorepo.DisplayMotos();
            #endregion

            #region Read
            Console.WriteLine("Getting a moto by ID: ");
            Motorcycle newmoto1 = motorepo.GetMotorcycleById(234);
            Motorcycle newmoto2 = motorepo.GetMotorcycleById(333);
            newmoto1?.DisplayStats();
            newmoto2?.DisplayStats();

            List<Motorcycle> motocollection = motorepo.GetMotoList();
            #endregion

            #region Update
            Console.WriteLine("Updating info for a moto: ");
            ducatti.Odometer = 8;
            motorepo.UpdateMotorcycle(ducatti);

            Motorcycle harley = new Motorcycle(999, "Harley Davidson", "hd1", 1998, 120000);
            motorepo.UpdateMotorcycle(harley);

            motorepo.DisplayMotos();
            #endregion

            #region Delete
            Console.WriteLine("Deleting a moto: ");
            motorepo.DeleteMotorcycle(234);

            motorepo.DisplayMotos();
            #endregion

            Log.CloseAndFlush();
        }
    }
}
