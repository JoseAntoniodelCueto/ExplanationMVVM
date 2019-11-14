using MyFirstMVVM.Model;
using MyFirstMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MyFirstMVVM.ViewModel
{
    //Heredamos el BaseViewModel con la intención de obtener todas las funcionalidades básicas para el ViewModel
    public class MainViewModel : BaseViewModel
    {
                
        //Cuando creamos un comando, creamos el campo privado de la implementación de ICommand, en este caso RelayCommand.
        //Y la interfaz será publica, ya que es el mínimo exponente necesario para su uso.
        private RelayCommand _checkTextGreetingsCommand;
        public ICommand CheckTextGreetingsCommand => _checkTextGreetingsCommand;
        
        private RelayCommand<string> _insertNumberCommand;
        public ICommand InsertNumberCommand => _insertNumberCommand;
        
        public MainViewModel()
        {            
            _checkTextGreetingsCommand = new RelayCommand(PerformCheckText);
            _insertNumberCommand = new RelayCommand<string>(PerformInsertNumber);
        }

        private void PerformInsertNumber(string obj)
        {
            TextGreetings += obj;            
        }

        private void PerformCheckText()
        {
            if(_textGreetings == "Hello World")
            {
                //TODO: Create NavigationService
                //MessageBox.Show("Bien!");
            }
            else
            {
                //TODO: Create NavigationService
                //MessageBox.Show("Mal");
            }
        }

        private string _textGreetings;

        public string TextGreetings
        {
            get => _textGreetings;
            set
            {
                _textGreetings = value;
                //Cuando hacemos llamada del método RaiseProperty lanzamos la notificación de que esta 
                //propiedad se ha visto modificada, para que todos los interesados puedan consultar su valor.
                RaiseProperty();
            }
        }        
    }
}
