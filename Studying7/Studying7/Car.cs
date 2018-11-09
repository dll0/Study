using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying7 {
    class Car {
        public string HorsePower { get; set; }
        public string Color { get; set; }
        protected bool isRepaired;

        public Car(string horsePower, string color) {
            HorsePower = horsePower;
            Color = color;
            isRepaired = false;
        }

        public virtual void ShowDetails() {
            Console.WriteLine($"This car has {HorsePower} horsepower and its color's {Color}");
        }

        public virtual void CarRepair() {
            if (!isRepaired) {
                isRepaired = true;
                Console.WriteLine("Car fixed!");
            } else {
                Console.WriteLine("Car isn't broken!");
            }
        }
    }
}
