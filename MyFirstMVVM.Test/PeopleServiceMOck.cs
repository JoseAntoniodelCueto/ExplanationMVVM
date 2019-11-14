using MyFirstMVVM.Model;
using MyFirstMVVM.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMVVM.Test
{
    public class PeopleServiceMock : IPeopleService
    {
        public List<Person> GetPeople()
        {
            return new List<Person>();
        }
    }
}
