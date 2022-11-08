using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarAdd();
            //GetAll();
            //GetCarsByColorId();
            //GetCarsByBrandId();
            Console.ReadLine();
        }
        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Rules rules = new Rules();
            
            var car = new Car {
                BrandId = 1,
                ColorId=1,
                ModelYear=Convert.ToDateTime("13.09.2005"),
                DailyPrice=200,
                Description="A"};

            if (car.DailyPrice<0)
            {
                Console.WriteLine(rules.CarDailyPriceRule);
            }
            else if (car.Description.Length < 2)
            {
                Console.WriteLine(rules.CarMinTwoCharacters);
            }
            else
            {
                carManager.CarAdd(car);
                Console.WriteLine(rules.CarAdded);
            }
            

        }
        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarsByBrandId(2))
            {
                Console.Write("Araba Id : " + item.CarId +
                              " Marka Id : " + item.BrandId +
                              " Renk Id : " + item.ColorId +
                              " Model Yılı : " + item.ModelYear.ToString("yyyy") +
                              " Günlük Fiyat : " + item.DailyPrice +
                              " Açıklama : " + item.Description);
                Console.WriteLine();
            }
            
        }
        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarsByColorId(2))
            {
                Console.Write("Araba Id : " + item.CarId +
                              " Marka Id : " + item.BrandId +
                              " Renk Id : " + item.ColorId +
                              " Model Yılı : " + item.ModelYear.ToString("yyyy") +
                              " Günlük Fiyat : " + item.DailyPrice +
                              " Açıklama : " + item.Description);
                Console.WriteLine();
            }
            
        }
        private static void GetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.Write("Araba Id : " + item.CarId +
                              " Marka Id : " + item.BrandId +
                              " Renk Id : " + item.ColorId +
                              " Model Yılı : " + item.ModelYear.ToString("yyyy") +
                              " Günlük Fiyat : " + item.DailyPrice +
                              " Açıklama : " + item.Description);
                Console.WriteLine();
            }
            
        }
    }
}
