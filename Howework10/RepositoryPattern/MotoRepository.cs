using Serilog;
using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    class MotoRepository : IMotorcycleRepository
    {
        private static List<Motorcycle> motorcycles = new List<Motorcycle>();

        public List<Motorcycle> GetMotoList()
        {
            Log.Information("Successfuly retrieved motorcycles collection by request.");
            return motorcycles;
        }

        public Motorcycle GetMotorcycleById(int motoId)
        {
            for (int i = 0; i < motorcycles.Count; i++)
            {
                Motorcycle moto = motorcycles[i];
                if (moto.Id == motoId)
                {
                    Log.Information("Successfully retrieved motorcycle {@moto} by ID {motoId}, as it doesn't exist in the current motorcycle collection", moto, motoId);
                    return moto;
                }
            }
            Log.Error($"Could not retrieve a motorcycle by ID {motoId}");
            return null;
        }

        public void CreateMotorcycle(Motorcycle moto)
        {
            motorcycles.Add(moto);
            Log.Information("Successfully added motorcycle {@moto} to the motorcycles collection", moto);
        }

        public void DeleteMotorcycle(int motoId)
        {
            bool idIsValid = false;
            for (int i = 0; i < motorcycles.Count; i++)
            {
                Motorcycle moto = motorcycles[i];
                if (moto.Id == motoId)
                {
                    motorcycles.Remove(moto);
                    Log.Information("Successfuly deleted motorcycle {@moto} from the motorcycles collection", moto);
                    idIsValid = true;
                    break;
                }
            }
            if (!idIsValid)
                Log.Error($"Could not delete motorcycle as ID {motoId} is not valid");
        }

        public void UpdateMotorcycle(Motorcycle moto)
        {
            bool motoExists = false;
            for (int i = 0; i < motorcycles.Count; i++)
            {
                if (motorcycles[i].Id == moto.Id)
                {
                    motoExists = true;
                    motorcycles.Remove(motorcycles[i]);
                    motorcycles.Add(moto);
                    Log.Information("Successfully updated motorcycle {@moto}", moto);
                    break;
                }
            }
            if (!motoExists)
                Log.Error("Could not update motorcycle {@moto}, as it doesn't exist in the current motorcycle collection", moto);
        }

        public void DisplayMotos()
        {
            foreach (var moto in motorcycles)
            {
                Console.WriteLine($"ID: {moto.Id}, Name: {moto.Name}, Year: {moto.Year}, Odometer: {moto.Odometer}");
            }
        }
    }
}
