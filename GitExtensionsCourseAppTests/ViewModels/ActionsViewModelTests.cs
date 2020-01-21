using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace GitExtensionsCourseAppTests.ViewModels {
    [TestClass]
    public class ActionsViewModelTests {
        private ActionsViewModel _model;

        [TestInitialize]
        public void Initialize() {
            _model = ContainerHelper.Container.Resolve<ActionsViewModel>();
        }

        [TestMethod]
        public void TestActionsViewModel() {
            Assert.IsNotNull(_model.Average);
            Assert.IsFalse(_model.IsCalculated);
        }

        [TestMethod]
        public void TestCalculateCommand() {
            _model.CalculateCommand.Execute(null);

            Assert.IsNotNull(_model.Average);
            Assert.IsTrue(_model.IsCalculated);
        }

    }
}
