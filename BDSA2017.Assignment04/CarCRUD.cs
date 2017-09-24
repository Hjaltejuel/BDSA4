using BDSA2017.Assignment04.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2017.Assignment04
{
    public class CarCRUD : IDisposable
    {
        private readonly RaceContext _context;

        public CarCRUD(RaceContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        /// <returns>The id of the newly created car</returns>
        public int Create(Entities.Cars car)
        {
            using (_context) { 
               _context.Cars.Add(car);
                _context.SaveChanges();
                }
                return car.Id;
           
        }

        public Cars FindById(int id)
        {
            using (_context)
            {
                var car = _context.Cars.Find(id);
                return car;
            }
            
        }

        public ICollection<Entities.Cars> All()
        {
            using (_context)
            {
                return _context.Cars.ToList();
            }
            
        }

        public void Update(Cars car)
        {
            using (_context)
            {
                foreach (Cars vehicle in _context.Cars)
                {
                    vehicle.Name = car.Name;
                }
                _context.SaveChanges();
            }
            
            
        }

        public void Delete(int carId)
        {
            using (_context)
            {
                var test = _context.Cars.Find(carId);
                _context.Remove(test);
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
