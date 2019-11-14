using MyFirstMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVVM.Model
{
    public class Person : BaseViewModel
    {
        private string _name;

        public string Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                //RaiseProperty();
            }
        }

        public EnumSex Sex { get; set; }
        public string ImageUrl { get; set; }        
    }
}
