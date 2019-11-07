using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MyFirstMVVM.Control
{
    /// <summary>
    /// Interaction logic for LabelAndTextBox.xaml
    /// </summary>
    public partial class LabelAndTextBox : UserControl
    {
        
        public LabelAndTextBox()
        {            
            InitializeComponent();
        }

        public Brush LabelColor
        {
            get => LabelTitle.Foreground;
            set => LabelTitle.Foreground = value;
        }
    }
}
