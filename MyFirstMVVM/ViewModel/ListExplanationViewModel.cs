using MyFirstMVVM.Model;
using MyFirstMVVM.Services;
using MyFirstMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMVVM.ViewModel
{
    public class ListExplanationViewModel : BaseViewModel
    {        
        private RelayCommand _commandChangeName;
        public ICommand CommandChangeName => _commandChangeName;

        private RelayCommand _commandAddNewElement;

        public ICommand CommandAddNewElement => _commandAddNewElement;


        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People
        {
            get => _people;
            set
            {
                _people = value;
                RaiseProperty();
            }
        }

        public ListExplanationViewModel()
        {            
            LoadPeople();
            InitCommands();
        }

        private void InitCommands()
        {
            _commandChangeName = new RelayCommand(PerformChangeName);
            _commandAddNewElement = new RelayCommand(PerformAddNewElement);
        }

        private void PerformAddNewElement()
        {
            People.Add(new Person() { Name = "Nacho" });            
        }

        private void PerformChangeName()
        {
            _people[0].Name = "Francisco";
        }

        private void LoadPeople()
        {
            _people = 
                new ObservableCollection<Person>(PeopleInstance.Instance.GetPeople());
        }
    }
}
