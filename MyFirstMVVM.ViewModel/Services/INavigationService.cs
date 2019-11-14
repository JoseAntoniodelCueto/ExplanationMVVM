using MyFirstMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.ViewModel.Services
{
    public interface INavigationService
    {
        void Show<T>() where T : BaseViewModel;
    }
}
