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
                new Person { SSN = "1", Name = "Karan", Address = "123 Main St", Age = 15 },
                new Person { SSN = "2", Name = "Manoj", Address = "456 Elm Sm", Age = 17 },
                new Person { SSN = "3", Name = "Khushi", Address = "789 Oak Sh", Age = 13 },
                new Person { SSN = "4", Name = "Krishna", Address = "789 Oak Sf", Age = 65 },
                new Person { SSN = "5", Name = "Ajay", Address = "789 Oak Sd", Age = 70 },
                new Person { SSN = "6", Name = "Mahi", Address = "789 Oak Sq", Age = 14 },
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

            Console.WriteLine("------------------------------------------------");



            //----------------------------  UC2-------------------
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

            Console.WriteLine("---------------------------------------------------------------------");

            // -------------------- UC3 ----------------------------
            Console.WriteLine(" All Records between the age of 13 to 18 year ");
            List<Person> filteredPersons1 = person.AllRecordBw13to18(personList);
            foreach (var person1 in filteredPersons1)
            {
                Console.WriteLine("SSN: " + person1.SSN);
                Console.WriteLine("Name: " + person1.Name);
                Console.WriteLine("Address: " + person1.Address);
                Console.WriteLine("Age: " + person1.Age);
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------------------");

            // ------------  UC4  ----------------------
            Console.WriteLine("Calculate Average age");
            double averageAge = person.CalculateAverageAge(personList);
            Console.WriteLine("Average Age: " + averageAge);

            Console.WriteLine("--------------------------------------------------------------");


            // ----------- UC5 -------------------------
            Console.WriteLine("Checking specific name is present or not ");

            Console.WriteLine("Enter a name to check:");
            string nameToCheck = Console.ReadLine();

            bool nameExists = person.CheckNameExists(personList, nameToCheck);

            if (nameExists)
                Console.WriteLine("The name exists in the list.");
            else
                Console.WriteLine("The name does not exist in the list.");

            Console.WriteLine("--------------------------------------------------------------");


            // ---------------- UC6 -------------------------
            Console.WriteLine("Skip those records whose age is lesss then 60 year");
            List<Person> skipPerson = person.SkipBelow60(personList);

            foreach (var person2 in skipPerson)
            {
                Console.WriteLine("Name: " + person2.Name);
                Console.WriteLine("Age: " + person2.Age);
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------------------------------");



            // ----------- UC7 -------------------------
            Console.WriteLine("Removing Specific record in the list by the name :");
            Console.WriteLine("Enter the name to remove: ");
            string nameToRemove = Console.ReadLine();

            List<Person> updatedPersons = person.RemovePersonByName(personList, nameToRemove);

            foreach (var person5 in updatedPersons)
            {
                Console.WriteLine("Name: " + person5.Name);
                Console.WriteLine("Age: " + person5.Age);
                Console.WriteLine();
            }

        }

    }
}
    
