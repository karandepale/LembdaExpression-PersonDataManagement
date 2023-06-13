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
                new Person { SSN = "2", Name = "Manoj", Address = "456 Elm Sm", Age = 25 },
                new Person { SSN = "3", Name = "Khushi", Address = "789 Oak Sh", Age = 40 },
                new Person { SSN = "4", Name = "Krishna", Address = "789 Oak Sf", Age = 65 },
                new Person { SSN = "5", Name = "Ajay", Address = "789 Oak Sd", Age = 70 },
                new Person { SSN = "6", Name = "Mahi", Address = "789 Oak Sq", Age = 90 },
                new Person { SSN = "7", Name = "Atul", Address = "789 Oak Sr", Age = 40 }
            };

            foreach (var personn in personList)
            {
                Console.WriteLine("SSN: " + personn.SSN);
                Console.WriteLine("Name: " + personn.Name);
                Console.WriteLine("Address: " + personn.Address);
                Console.WriteLine("Age: " + personn.Age);
                Console.WriteLine();
            }

            Console.WriteLine(" two Person name whose age is less then 60 year ");

            Person person = new Person();
            List<Person> filteredPersons = person.RetrieveTop2(personList);

            // Print the filtered persons
            foreach (var personn in filteredPersons)
            {
                Console.WriteLine("Name: " + personn.Name);
                Console.WriteLine("Age: " + personn.Age);
                Console.WriteLine();
            }

        }

    }
}
    
