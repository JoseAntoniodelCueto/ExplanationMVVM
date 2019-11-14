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

        private RelayCommand<Person> _selectedPersonCommand;
        public ICommand SelectedPersonCommand => _selectedPersonCommand;
        
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

        private int _personIndex;

        public int PersonIndex
        {
            get => _personIndex;
            set
            {
                _personIndex = value;
                RaiseProperty();
            }
        }

        private Person _selectedPerson;

        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                SelectedPersonCommand.Execute(_selectedPerson);
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
            _selectedPersonCommand = new RelayCommand<Person>(PerformSelectedPerson);
        }

        private void PerformSelectedPerson(Person obj)
        {
            //TODO: Do something with person
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
