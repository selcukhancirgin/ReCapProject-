﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id= 1,
                        BrandId = 1,
                        ColorId = 1,
                        ModelYear = Convert.ToDateTime("18.10.2006") ,
                        DailyPrice = 2000,
                        Description = "Açıklama1"},
                new Car {Id= 2,
                        BrandId = 1,
                        ColorId = 2,
                        ModelYear = Convert.ToDateTime("20.09.2001") ,
                        DailyPrice = 200,
                        Description = "Açıklama2"},
                new Car {Id= 3,
                        BrandId = 1,
                        ColorId = 3,
                        ModelYear = Convert.ToDateTime("13.09.2006") ,
                        DailyPrice = 400,
                        Description = "Açıklama3"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate  = _cars.SingleOrDefault(x => x.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}