using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyFirstMVVM.ViewModel.Base
{
    //Implementamos INotifyPropertyChanged para poder invocar el evento de PropertyChanged
    //Que nos permitirá notificar a Vista y ViewModel por igual

    //Está clase se plantea abstracta (Que no tiene instancia, ya que solo la usaremos como padre)
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseProperty([CallerMemberName] string propertyName = "")
        {            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));            
        }        
    }
}
