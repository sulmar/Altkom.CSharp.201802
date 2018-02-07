using Altkom.CSharp.RentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alktom.CSharp.RentSystem.ConsoleClient
{
    public interface IPersonsService
    {
        Person GetByName(string fullname);

        Person Get(int id);

        void Add(Person person);

        void Update(Person person);

        void Remove(int id);
    }


    public class MockPersonsService : IPersonsService
    {
        private List<Person> persons = new List<Person>();

        // snippet: ctor
        public MockPersonsService()
        {
            var person1 = new Woman
            {
                Id = 1,
                FirstName = "Ania",
            };

            var person2 = new Woman
            {
                Id = 2,
                FirstName = "Agnieszka"
            };

            var person3 = new Man
            {
                Id = 3,
                FirstName = "Wojtek"
            };

            var person4 = new Man
            {
                Id = 4,
                FirstName = "Rafael"
            };

            var person5 = new Man
            {
                Id = 5,
                FirstName = "Michał"
            };

            var person6 = new Man
            {
                Id = 6,
                FirstName = "Tomek"
            };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);
            persons.Add(person5);
            persons.Add(person6);
        }

        public void Add(Person person)
        {
            persons.Add(person);
        }

        public Person GetByName(string fullname)
        {
            return persons.Where(person => person.FirstName == fullname).FirstOrDefault();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            return persons.Where(p => p.Id == id).FirstOrDefault();

            // return persons.FirstOrDefault(p=>p.Id == id);

        }
    }
}
