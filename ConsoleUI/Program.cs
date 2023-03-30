using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carmanager = new CarManager(new EfCarDal(),new EfBrandDal(),new EfColorDal());
            ColorManager colormaganer = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());

            //var result1 = customerManager.Add(new Customer { CompanyName = "İntif" } );
            //if (result1.Success)
            //{
            //    Console.WriteLine(result1.Message);
            //}
            //var rentalResult2 = rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = new DateTime(2023, 02, 25), ReturnDate = new DateTime(2023, 02, 28) });

            //if (rentalResult2.Success)
            //{
            //    Console.WriteLine(rentalResult2.Message);
            //}
            //else
            //{
            //    Console.WriteLine(rentalResult2.Message);
            //}
            //foreach (var Car in carmanager.GetCarDetails().Data)
            //{
            //    Console.WriteLine(Car.BrandId + "/" + Car.BrandId);
            //}

            //foreach (var Color in colormaganer.GetAll())x
            //{
            //    Console.WriteLine(Color.ColorId);
            //}
            //foreach (var Brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(Brand.BrandName);
            //}

            //foreach (var Car in carmanager.GetAll())
            //{
            //    Console.WriteLine(Car.CarName);
            //    Console.WriteLine(Car.ModelYear);
            //    Console.WriteLine(Car.DailyPrice);

            //}
            //var result = carmanager.GetCarsByModelYear();

            //foreach (var car in result.Data)
            //{
            //    Console.WriteLine(car.CarName);
            //}

            //Car car = new Car()
            //{
            //    CarName = "AUDİ",
            //    ModelYear = 2001,
            //    DailyPrice = 50
            //};
            //carmanager.add(car);
            //carmanager.Update(car);
            //carmanager.delete(car);

            //var result = carmanager.GetAll();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.CarName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }
    }
}
