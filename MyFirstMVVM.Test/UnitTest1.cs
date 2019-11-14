using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstMVVM.ViewModel;
using MyFirstMVVM.ViewModel.Services;
using System.Linq;

namespace MyFirstMVVM.Test
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void AddNewElementItsNacho()
        {
            Locator.Register<INavigationService>(new NavigationServiceMock());
            var vm = new ListExplanationViewModel(null);
            vm.CommandAddNewElement.Execute(null);            
            Assert.AreEqual(true, vm.People.Any(x => x.Name == "Nacho"));
        }

        [TestMethod]
        public void WhenNotArePeopleInMyList()
        {
            Locator.Register<INavigationService>(new NavigationServiceMock());
            var vm = new ListExplanationViewModel(new PeopleServiceMock());
            vm.OnLoad();
            Assert.AreEqual(0, vm.People.Count);
        }
    }
}