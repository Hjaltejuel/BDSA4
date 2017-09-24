using BDSA2017.Assignment04.Entities;
using System.Linq;
using Xunit;

using System;
using System.Diagnostics;
namespace BDSA2017.Assignment04.Tests
{
    public class CarCRUDTests
    {
        RaceContext context = new RaceContext();
        CarCRUD CarCRUD = new CarCRUD(new RaceContext());

       

        [Fact]
        public void TestCarCreate() 
        {
            var Car = new Cars { Name = "Test", DriverName = "Test" };
            
            Assert.NotNull(context.Cars.Where(a => a.Id == CarCRUD.Create(Car)).FirstOrDefault());
           
        }

        [Fact]
        public void TestFindById()
        {
            var car = new Cars { Name = "Test2", DriverName = "Test2" };
            int id = CarCRUD.Create(car);


            Assert.Equal(id,CarCRUD.FindById(id).Id);
           
        }
        
        [Fact]
        public void TestAll()
        {
            var all = context.Cars.ToList();
            Assert.True(all.OrderBy(i => i).SequenceEqual(
                 CarCRUD.All().OrderBy(i => i)));
           
        }
    
        [Fact]
        public void TestUpdate()
        {
            var car = new Cars { Name = "Update" };
            CarCRUD.Update(car);
            
            Assert.NotNull(context.Cars.Where(a=> a.Name.Contains("Update")).FirstOrDefault());
        }
        [Fact]
        public void TestDelete()
        {
            var id = CarCRUD.Create(new Cars { Name = "hej", DriverName = "hehe" });
            CarCRUD.Delete(id);
            Assert.Null(context.Cars.Find(id));
        }
       
    }
}
