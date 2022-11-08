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
            //RentalAdd();
            //CarAdd();
            //GetAll();
            //GetCarsByColorId();
            //GetCarsByBrandId();
            //GetCarDetails();
            Console.ReadLine();
        }
        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var rental = new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = Convert.ToDateTime("13.09.2005"),
                ReturnDate = Convert.ToDateTime("13.09.2005")
            };

            var result = rentalManager.RentalAdd(rental);
            Console.WriteLine(result.Message); //Hata verir.
        }
        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            var car = new Car {
                BrandId = 1,
                ColorId=1,
                ModelYear=Convert.ToDateTime("13.09.2005"),
                DailyPrice=200,
                Description="A"};

                carManager.CarAdd(car);
          
            

        }
        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarsByBrandId(2).Data)
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
        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.Write(" Araba Adı : " + item.CarName +
                              " Marka Adı : " + item.BrandName +
                              " Renk Adı : " + item.ColorName +
                              " Günlük Fiyat : " + item.DailyPrice
                              );
                Console.WriteLine();
            }

        }
        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarsByColorId(2).Data)
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
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.Write("Araba Id : " + item.CarId +
                                  " Marka Id : " + item.BrandId +
                                  " Renk Id : " + item.ColorId +
                                  " Model Yılı : " + item.ModelYear.ToString("yyyy") +
                                  " Günlük Fiyat : " + item.DailyPrice +
                                  " Açıklama : " + item.Description);
                    Console.WriteLine();
                }
                Console.WriteLine(result.Message);
            }
               
            
        }
    }
}
