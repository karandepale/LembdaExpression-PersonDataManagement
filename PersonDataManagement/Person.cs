using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Person
    {
        public string SSN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public List<Person> RetrieveTop2(List<Person> personList)
        {
            var filteredPersons = personList.Where(person => person.Age < 60)
                                            .Take(2)
                                            .ToList();

            return filteredPersons;
        }

        public List<Person> AllRecordBw13to18(List<Person> personList)
        {
            var filteredPersons = personList.Where(person => person.Age >= 13 && person.Age <= 18)
                                            .ToList();

            return filteredPersons;
        }


        public double CalculateAverageAge(List<Person> personList)
        {
            double averageAge = personList.Average(person => person.Age);
            return averageAge;
        }


        public bool CheckNameExists(List<Person> personList, string name)
        {
            return personList.Any(person => person.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }


        public List<Person> SkipBelow60(List<Person> personList)
        {
            var filteredPersons = personList.Where(person => person.Age >= 60)
                                            .ToList();

            return filteredPersons;
        }



        public List<Person> RemovePersonByName(List<Person> personList, string name)
        {
            var filteredPersons = personList.Where(person => !person.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                                            .ToList();

            return filteredPersons;
        }

    }
}
