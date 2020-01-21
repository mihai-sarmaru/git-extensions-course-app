using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace GitExtensionsCourseAppTests.ViewModels {
    [TestClass]
    public class PersonListViewModelTests {
        private PersonListViewModel _model;

        [TestInitialize]
        public void Initialize() {
            _model = ContainerHelper.Container.Resolve<PersonListViewModel>();
        }

        [TestMethod]
        public void TestPersonListViewModel() {
            Assert.IsNotNull(_model.PersonList);
        }

        [TestMethod]
        public void TestOnRefresh() {
            _model.RefreshCommand.Execute(null);
            Assert.IsNotNull(_model.PersonList);
        }
    }
}
