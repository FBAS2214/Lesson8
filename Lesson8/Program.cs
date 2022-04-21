using System;

namespace Lesson8
{

    class Car
    {
        private static Car _instance { get; set; }
        private Car() { }

        public static Car MakeCar(string model, string make, int year)
        {
            if (_instance == null)
                _instance = new Car();

            return _instance;
        }
    }

    public class Program
    {
        static void Main()
        {
            Car car1 = Car.MakeCar("1", "1", 2022);
            Car car2 = Car.MakeCar("2", "2", 2022);

            Console.WriteLine(car1.GetHashCode());
            Console.WriteLine(car2.GetHashCode());
        }
    }
}