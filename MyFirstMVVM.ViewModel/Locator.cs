using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.ViewModel
{
    public class Locator
    {
        private static Dictionary<Type, object> services = new Dictionary<Type, object>();

        public static T Get<T>() => (T)services[typeof(T)];

        public static void Register<T>(object impl) => services[typeof(T)] = impl;
    }
}
