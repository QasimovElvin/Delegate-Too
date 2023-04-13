using ConsoleApp23.Models;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Galery galery = new Galery();
            Car car1 = new Car("Mercedes",260,17000);
            Car car2 = new Car("Bmw", 260, 13000);
            Car car3 = new Car("Hyundai", 240, 16000);
            Car car4 = new Car("Kia", 220, 11500);
            galery.AddCar(car1);
            galery.AddCar(car2);
            galery.AddCar(car3);
            galery.AddCar(car4);
            galery.ShowAllCars();
            galery.CheapCar();
            galery.FindCarByCarCode("ME1001");
            galery.ExpensiveCar();
            galery.DeleteCar(3);
            galery.ShowAllCars();
            galery.FindCarsBySpeedInterval(100, 300);
            galery.FindById(2);
            galery.SumofAllCarsPrice();
        }
    }
}