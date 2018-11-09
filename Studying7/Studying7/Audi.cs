using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying7 {
    class Audi : Car{
        private string brand;

        public Audi(string horsePower, string color):base(horsePower, color) {
            HorsePower = horsePower;
            Color = color;
            isRepaired = false;
            brand = "Audi";
        }

        public override void ShowDetails() {
            Console.WriteLine($"This {brand} car has {HorsePower} horsepower and its color's {Color}");
        }

        public override void CarRepair() {
            if (!isRepaired) {
                isRepaired = true;
                Console.WriteLine($"{brand} fixed!");
            } else {
                Console.WriteLine($"{brand} isn't broken!");
            }
        }
    }
}
