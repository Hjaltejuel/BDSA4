using BDSA2017.Assignment04.Entities;
using System.Linq;
using Xunit;

using System;
using System.Diagnostics;
namespace BDSA2017.Assignment04.Tests
{
    public class CarCRUDTests
    {
        

       

        [Fact]
        public void TestCarCreate() 
        {
            using (RaceContext context = new RaceContext())
            {
                using (CarCRUD CarCRUD = new CarCRUD(new RaceContext()))
                {
                    var Car = new Cars { Name = "Test", DriverName = "Test" };

                    Assert.NotNull(context.Cars.Where(a => a.Id == CarCRUD.Create(Car)).FirstOrDefault());
                }
            
            }
           
        }

        [Fact]
        public void TestFindById()
        {
            using (RaceContext context = new RaceContext())
            {
                using (CarCRUD CarCRUD = new CarCRUD(new RaceContext()))
                {
                    var car = new Cars { Name = "Test2", DriverName = "Test2" };
                    context.Cars.Add(car);
                    context.SaveChanges();


                    Assert.Equal(car.Id, CarCRUD.FindById(car.Id).Id);
                }
            }
           
        }
        [Fact]
        public void TestAll()
        {
            bool test = true;
            using (RaceContext context = new RaceContext()) {
                var list1 = context.Cars.ToArray();
                using (CarCRUD CarCRUD = new CarCRUD(new RaceContext())) {
                    var list2 = CarCRUD.All().ToArray();
                    if(list1.Length != list2.Length)
                    {
                        test = false;
                        Assert.True(test);
                    }
                    Boolean equalTest = false;
                    foreach(Cars car in list1)
                    {
                        foreach (Cars car2 in list2)
                        {
                             if(car.Id == car2.Id)
                            {
                                equalTest = true;
                            }
                        }
                        if(equalTest!= true)
                        {
                            Assert.True(equalTest);
                        }
                    }
                    Assert.True(true);
                }
            }
        }
        
      
    
        [Fact]
        public void TestUpdate()
        {
            using (RaceContext context = new RaceContext())
            {
                using (CarCRUD CarCRUD = new CarCRUD(new RaceContext()))
                {
                    var car = new Cars { Name = "Update" };
                    CarCRUD.Update(car);

                    Assert.NotNull(context.Cars.Where(a => a.Name.Contains("Update")).FirstOrDefault());
                }
            }
        }
        [Fact]
        public void TestDelete()
        {
            Cars car = new Cars { Name = "hej", DriverName = "hehe" };
            using (RaceContext context = new RaceContext())
            {
                
                context.Cars.Add(car);
                context.SaveChanges();
            }
             using (CarCRUD CarCRUD = new CarCRUD(new RaceContext() ))
             {
                CarCRUD.Delete(car.Id);
                
             }
            using (RaceContext context = new RaceContext())
            {
                Assert.Null(context.Cars.Find(car.Id));
            }
        }
        [Fact]
        public void TestDisposed()
        {

            using (CarCRUD CarCRUD = new CarCRUD(new RaceContext()))
            {
                CarCRUD.Dispose();
                try
                {
                    CarCRUD.Create(new Cars { Name = "hello", DriverName = "hn" });
                    Assert.True(false);
                }
                catch (Exception e)
                {
                    Assert.True(true);
                }
            }
                
        }
       
    }
}
