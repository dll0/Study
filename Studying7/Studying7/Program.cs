using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Polimorfismo

namespace Studying7 {
    class Program {
        static void Main(string[] args) {
            var cars = new List<Car> {
                new Audi("700", "blue"),
                new BMW("850", "pink")
            };

            foreach(var car in cars) {
                car.CarRepair();
            }

            Console.ReadKey();
        }
    }
}
