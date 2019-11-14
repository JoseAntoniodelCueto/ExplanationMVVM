using MyFirstMVVM.Model;
using MyFirstMVVM.Services;
using MyFirstMVVM.ViewModel.Base;
using MyFirstMVVM.ViewModel.Services;
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
        private readonly INavigationService _navigationService;
        private readonly IPeopleService _peopleService;

        private RelayCommand _commandChangeName;
        public ICommand CommandChangeName => _commandChangeName;

        private RelayCommand _commandAddNewElement;

        private RelayCommand<Person> _selectedPersonCommand;
        public ICommand SelectedPersonCommand => _selectedPersonCommand;
        
        public ICommand CommandAddNewElement => _commandAddNewElement;

        private ObservableCollection<Person> _people = new ObservableCollection<Person>();

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
                _commandChangeName.RaiseCanExecute();
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
        
        public ListExplanationViewModel(IPeopleService peopleService)
        {
            _navigationService = Locator.Get<INavigationService>();
            _peopleService = peopleService;
            InitCommands();
        }

        public override void OnLoad()
        {
            LoadPeople();
            base.OnLoad();
        }

        private void InitCommands()
        {
            _commandChangeName = new RelayCommand(PerformChangeName, CanExecuteChangeName);
            _commandAddNewElement = new RelayCommand(PerformAddNewElement);
            _selectedPersonCommand = new RelayCommand<Person>(PerformSelectedPerson);
        }

        private bool CanExecuteChangeName()
        {
            if(PersonIndex >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            _navigationService.Show<MainViewModel>();            
        }

        private void LoadPeople()
        {
            _people = 
                new ObservableCollection<Person>(_peopleService.GetPeople());
        }
    }
}
