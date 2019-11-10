using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstMVVM.Model;

namespace MyFirstMVVM.Services
{
    public class DummyPeopleService : IPeopleService
    {
        public List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person() { Name = "Paco"},
                new Person() { Name = "Maria"},
                new Person() { Name = "Federico"},
            };
        }
    }
}
