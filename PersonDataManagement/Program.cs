using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>
            {
                new Person { SSN = "1", Name = "Karan", Address = "123 Main St", Age = 30 },
                new Person { SSN = "2", Name = "Manoj", Address = "456 Elm St", Age = 25 },
                new Person { SSN = "3", Name = "Khushi", Address = "789 Oak St", Age = 40 },
                new Person { SSN = "4", Name = "Krishna", Address = "789 Oak St", Age = 65 },
                new Person { SSN = "5", Name = "Ajay", Address = "789 Oak St", Age = 70 },
                new Person { SSN = "6", Name = "Mahi", Address = "789 Oak St", Age = 80 },
                new Person { SSN = "7", Name = "Atul", Address = "789 Oak St", Age = 40 }
            };

            foreach (var person in personList)
            {
                Console.WriteLine("SSN: " + person.SSN);
                Console.WriteLine("Name: " + person.Name);
                Console.WriteLine("Address: " + person.Address);
                Console.WriteLine("Age: " + person.Age);
                Console.WriteLine();
            }

        }

    }
}
    
