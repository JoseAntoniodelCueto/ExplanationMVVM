using MyFirstMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFirstMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        private MainViewModel vm;
        public MainWindow()
        {
            InitializeComponent();

            //Añadimos el contexto de Datos para que Vista y ViewModel se encuentren conectados
            vm = new MainViewModel();            
            DataContext = vm;                        
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            vm.OnLoad();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            vm.OnClosed();
        }
    }
}
