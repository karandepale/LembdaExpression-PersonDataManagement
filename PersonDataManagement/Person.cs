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
    }
}
