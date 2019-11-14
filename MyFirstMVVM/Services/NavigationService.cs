using MyFirstMVVM.View;
using MyFirstMVVM.ViewModel;
using MyFirstMVVM.ViewModel.Base;
using MyFirstMVVM.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyFirstMVVM.Services
{
    public class NavigationService : INavigationService
    {
        private Dictionary<Type, Type> vmAndViews = new Dictionary<Type, Type>()
        {
            { typeof(MainViewModel), typeof(MainWindow) },
            { typeof(ListExplanationViewModel), typeof(ListExplanation) }
        };

        public void Show<T>() where T : BaseViewModel
        {
            var viewType = vmAndViews[typeof(T)];

            
            var view = (Window)Activator.CreateInstance(viewType);
            var vm = Activator.CreateInstance<T>();

            view.DataContext = vm;
            view.Show();            
        }
    }
}
