using MyFirstMVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.Services
{
    public interface IPeopleService
    {
        List<Person> GetPeople();
    }
}
