using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.ViewModel.Services
{
    public interface INotificationService
    {
        void ShowMessage(string title, string message);
    }
}
