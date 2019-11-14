using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.ViewModel.Services
{
    public class NavigationImplentation
    {
        private static INavigationService _instance;

        public static Func<INavigationService> _instanceFunction;
        public NavigationImplentation(Func<INavigationService> instanceFunction)
        {
            _instanceFunction = instanceFunction;
        }

        public static INavigationService Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = _instanceFunction.Invoke();
                }

                return _instance;
            }
        }
    }
}
