using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp23.Models
{
    internal class Galery
    {
        private string _name;

        public string NAME
        {
            get { return _name; }
            set
            {
                if (value.Length > 0)
                {
                    _name = value;
                }
            }
        }

        List<Car> Cars = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public void ShowAllCars()
        {
            Cars.ForEach(ca => Console.WriteLine(ca));
        }
        public void FindById(int id)
        {
            Console.WriteLine(Cars.Find(x => x.Id == id));
        }
        public void FindCarByCarCode(string carcode)
        {
            Console.WriteLine(Cars.Find(x => x.Carcode == carcode));
        }
        public void DeleteCar(int id)
        {
            Cars.Remove(Cars.Find(x => x.Id == id));    

        }
        public void FindCarsBySpeedInterval(int min , int max)
        {
            Cars.FindAll(x => x.Speed > min && x.Speed < max).ForEach(x => Console.WriteLine(x));
        }
        public void SumofAllCarsPrice()
        {
            Console.WriteLine(Cars.Sum(x => x.Price));

        }
        public void ExpensiveCar()
        {
            ;
            Console.WriteLine($"Galerideki en bahali masinin qiymeti:{Cars.Max(x => x.Price)}");
        }
        public void CheapCar()
        {
            Cars.Min(x => x.Price);
            Console.WriteLine($"Galerideki en ucuz masinin qiymeti:{Cars.Min(x => x.Price)}");
        }
    }
}
