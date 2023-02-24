using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carmanager = new CarManager(new EfCarDal());
            ColorManager colormaganer = new ColorManager(new EfColorDal());
            BlandManager brandManager = new BlandManager(new EfBrandDal());

            foreach (var Car in carmanager.GetCarDetails())
            {
                Console.WriteLine(Car.CarName +"/"+ Car.BrandName);
            }

            //foreach (var Color in colormaganer.GetAll())
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

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CarName);
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
        }
    }
}
