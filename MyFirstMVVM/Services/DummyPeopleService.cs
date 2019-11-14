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
                new Person() { Name = "Paco", Sex = EnumSex.Male},
                new Person() { Name = "Maria", Sex = EnumSex.Female},
                new Person() { Name = "Federico", Sex = EnumSex.Male},
            };
        }
    }
}
