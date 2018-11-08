using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Create a main class with a Main Method, then a base class Employee with the properties Name, 
        FirstName, Salary and the methods Work() and Pause().
        Create a deriving class boss with the propertie CompanyCar and the method Lead(). 
        Create another deriving class of employees - trainees with the properties WorkingHours 
        and SchoolHourse and a method Learn().

        Override the methods Work() of the trainee class so that it indicates the working hours 
        of the trainee.

        Don’t forget to create the constructors.

        Create an object of each of the three classes (with arbitrary values)

        and call the methods, Lead() of Boss and Work() of Trainee.

        Just print out the respective text, what the respective employees do.
*/

    //Fiquei com preguiça de fazer a classe do Trainee

namespace Studying6 {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee("Oliveira", "Matheus", 865.9);

            employee.Work();
            Console.WriteLine(employee.ToString());

            employee.Pause();
            Console.WriteLine(employee.ToString());

            Boss boss = new Boss("Fagundes", "Roberto", 20000, "Cobalt SS");

            foreach (int i in Enumerable.Range(0, 2)) {
                boss.Lead();
                Console.WriteLine(boss.ToString());
            }

            Console.ReadKey();
        }
    }
}
