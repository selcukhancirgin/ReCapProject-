using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll())
            {
                Console.Write("Araba Id : " + item.Id + 
                              " Marka Id : " + item.BrandId +
                              " Renk Id : " + item.ColorId +
                              " Model Yılı : " + item.ModelYear.ToString("yyyy") +
                              " Günlük Fiyat : " + item.DailyPrice + 
                              " Açıklama : " + item.Description);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
