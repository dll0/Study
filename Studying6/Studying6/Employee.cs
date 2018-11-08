using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying6 {
    class Employee {
        protected bool working = false;

        public string Name { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee(string name, string firstName, double salary) {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public void Work() {
            if (!working) {
                working = true;
                Console.WriteLine("O funcionário começou a trabalhar.");
            } else {
                Console.WriteLine("O funcionário já está trabalhando.");
            }
        }

        public void Pause() {
            if (working) {
                working = false;
                Console.WriteLine("O funcionário parou de trabalhar.");
            } else {
                Console.WriteLine("O funcionário não está trabalhando.");
            }
        }

        public override string ToString() {
            if (working) {
                return $"{FirstName} {Name} está trabalhando.";
            } else {
                return $"{FirstName} {Name} não está trabalhando.";
            }
        }
    }
}
