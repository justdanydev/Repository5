using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    public abstract class Vehicle
    {
        public abstract void StartEngine();
    }

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Включаем зажигание автомобиля...");
            Console.WriteLine("Двигатель автомобиля запущен.");
        }
    }

    public class Motorcycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Включаем зажигание мотоцикла...");
            Console.WriteLine("Двигатель мотоцикла запущен. Ррррр!");
        }
    }

    public class Example
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();

            Console.WriteLine("Запуск автомобиля:");
            car.StartEngine();

            Console.WriteLine("\nЗапуск мотоцикла:");
            motorcycle.StartEngine();
        }
    }
}
