using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MyFirstMVVM.Control
{
    public class TextBoxEnter : TextBox
    {
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(TextBoxEnter));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public TextBoxEnter()
        {
            this.KeyDown -= TextBoxEnter_KeyDown;
            this.KeyDown += TextBoxEnter_KeyDown;
        }

        private void TextBoxEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if(true)
            {
                Command?.Execute(null);
            }
        }
    }
}
