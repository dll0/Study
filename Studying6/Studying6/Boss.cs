using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studying6 {
    class Boss : Employee {
        public string CompanyCar { get; set; }

        public Boss() { }

        public Boss(string name, string firstName, double salary, string companyCar) {
            Name = name;
            FirstName = firstName;
            Salary = salary;
            CompanyCar = companyCar;
        }

        public void Lead() {
            if (!working) {
                working = true;
                Console.WriteLine("O chefe começou a xingar toda a equipe de " +
                    $"desenvolvimento, enquanto a culpa é do setor de testes, {Environment.NewLine}" +
                    "do setor de suporte, talvez seja da administração, " +
                    "programadores nunca erram.");
            } else {
                working = false;
                Console.WriteLine("O chefe dormiu.");
            }
        }

        public override string ToString() {
            if (working) {
                return $"{FirstName} {Name}, que possui um {CompanyCar}, está xingando o desenvolvimento.";
            } else {
                return $"{FirstName} {Name}, que possui um {CompanyCar}, está dormindo.";
            }
        }
    }
}
