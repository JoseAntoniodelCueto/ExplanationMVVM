using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.Services
{
    public class PeopleInstance
    {
        private static IPeopleService _instance;

        public static IPeopleService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DummyPeopleService();
                }
                return _instance;
            }
        }

        protected PeopleInstance()
        {
        }
    }
}
