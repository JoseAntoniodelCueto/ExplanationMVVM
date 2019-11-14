using MyFirstMVVM.ViewModel.Base;
using MyFirstMVVM.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstMVVM.Test
{
    public class NavigationServiceMock : INavigationService
    {
        public void Show<T>() where T : BaseViewModel
        {
            throw new NotImplementedException();
        }
    }
}
