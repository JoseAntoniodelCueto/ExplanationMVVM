using MyFirstMVVM.ViewModel.Services;
using System.Windows;

namespace MyFirstMVVM.Services
{
    public class NotificationService : INotificationService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
