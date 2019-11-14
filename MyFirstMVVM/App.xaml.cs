using MyFirstMVVM.Services;
using MyFirstMVVM.ViewModel;
using MyFirstMVVM.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyFirstMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {        
        protected override void OnStartup(StartupEventArgs e)
        {
            Locator.Register<INavigationService>(new NavigationService());
            base.OnStartup(e);
        }
    }
}
