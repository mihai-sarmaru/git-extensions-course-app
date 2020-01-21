using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Unity;

namespace GitExtensionsCourseAppTests.ViewModels {
    [TestClass]
    public class ActionsViewModelTests {
        private ActionsViewModel _model;
        private readonly string JSON_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "texts", "merged.json");

        [TestInitialize]
        public void Initialize() {
            _model = ContainerHelper.Container.Resolve<ActionsViewModel>();
        }

        [TestMethod]
        public void TestActionsViewModel() {
            Assert.IsNotNull(_model.Average);
            Assert.IsFalse(_model.IsCalculated);
            Assert.IsFalse(_model.IsMerged);
        }

        [TestMethod]
        public void TestOnMergeFiles() {
            _model.MergeFilesCommand.Execute(null);
            Assert.IsTrue(File.Exists(JSON_PATH));
            Assert.IsFalse(_model.HasEmployees);
            Assert.IsTrue(_model.IsMerged);
        }

        [TestMethod]
        public void TestCalculateCommand() {
            _model.CalculateCommand.Execute(null);

            Assert.IsNotNull(_model.Average);
            Assert.IsTrue(_model.IsCalculated);
        }

    }
}
