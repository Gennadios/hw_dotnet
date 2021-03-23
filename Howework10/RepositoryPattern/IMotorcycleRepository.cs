using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    interface IMotorcycleRepository
    {
        List<Motorcycle> GetMotoList();
        Motorcycle GetMotorcycleById(int motoId);
        void CreateMotorcycle(Motorcycle moto);
        void UpdateMotorcycle(Motorcycle moto);
        void DeleteMotorcycle(int motoId);
    }
}