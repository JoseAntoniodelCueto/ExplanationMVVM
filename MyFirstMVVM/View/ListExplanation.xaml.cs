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
using System.Windows.Shapes;

namespace MyFirstMVVM.View
{
    /// <summary>
    /// Interaction logic for ListExplanation.xaml
    /// </summary>
    public partial class ListExplanation : Window
    {
        public ListExplanation()
        {
            InitializeComponent();
            DataContext = new ListExplanationViewModel();
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            (DataContext as ListExplanationViewModel).CommandChangeName.Execute(null);
        }
    }
}
