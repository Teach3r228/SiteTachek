using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class mockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car  { name= "Tesla",shortDesc="Быстрый автомобиль",longDesc="Быстрый автомобиль, комфортабельбный",img="/img/tesla.jpg",price=4500,isFavorite=true,available=true,Category =  _carsCategory.AllCategories.First()},
                    new Car {name= "Жигуль",shortDesc="Тихий и спокойный",longDesc="Удобный автомобиль для городской жизни",img="/img/Zhigul.jpg",price=4500,isFavorite=true,available=true,Category =  _carsCategory.AllCategories.Last() }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }


        public Car getObjectCar(int cardId)
        {
            throw new NotImplementedException();
        }
    }
}
