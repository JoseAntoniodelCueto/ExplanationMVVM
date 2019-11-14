using MyFirstMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyFirstMVVM.View
{
    public abstract class BaseView<T> : Window where T: BaseViewModel
    {
        public T ViewModel
        {
            get => (T)DataContext;
        }

        public BaseView()
        {
            this.Loaded += BaseView_Loaded;
            this.Closed += BaseView_Closed;
        }

        private void BaseView_Closed(object sender, EventArgs e)
        {
            ViewModel.OnClosed();
        }

        private void BaseView_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.OnLoad();
        }


    }
}
