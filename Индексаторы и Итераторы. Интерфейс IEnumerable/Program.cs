using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индексаторы_и_Итераторы.Интерфейс_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Ford", Number = "CZ01AA07"},
                new Car() {Name = "Toyota", Number = "UA05AH49"}
            };

            var parking = new Parking();
            
            foreach(var car in cars)
            {
                parking.Add(car);
            }

            foreach(var car in parking)
            {
                Console.WriteLine(car);
            }

            foreach(var item in parking)
            {
                Console.WriteLine(item + " ");
            }

            foreach (var name in parking.GetNames())
            {
                Console.WriteLine($"Марка: {name}");
            }

            Console.WriteLine();

            Console.WriteLine(parking["CZ01AA07"]?.Name);
            Console.WriteLine(parking["CZ02AA07"]?.Name);

            Console.WriteLine("Введите номер нового автомобиля");
            var num = Console.ReadLine();
            parking[1] = new Car() { Name = "BMW", Number = num };
            Console.WriteLine(parking[1]);

            Console.ReadLine();
        }
    }
}
