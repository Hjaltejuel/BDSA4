using BDSA2017.Assignment04.Entities;
using System;
using System.Collections.Generic;

namespace BDSA2017.Assignment04
{
    public class CarCRUD : IDisposable
    {
        private readonly SlotCarContext _context;

        public CarCRUD(SlotCarContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        /// <returns>The id of the newly created car</returns>
        public int Create(Entities.Car car)
        {
            throw new NotImplementedException();
        }

        public Car FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Entities.Car> All()
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(int carId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
