using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Unity;

namespace GitExtensionsCourseAppTests.Services {
    [TestClass]
    public class TextRepositoryTests {
        private TextRepository _repo;
        private PrivateObject _privateRepo;

        private readonly string TEXT_FOLDER_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "texts");

        [TestInitialize]
        public void Initialize() {
            _repo = ContainerHelper.Container.Resolve<TextRepository>();
            _privateRepo = new PrivateObject(_repo);
            if (Directory.Exists(TEXT_FOLDER_PATH)) Directory.Delete(TEXT_FOLDER_PATH, true); 
        }

        [TestMethod]
        public void TestTextsPathExists() {
            Assert.IsFalse((bool)_privateRepo.Invoke("TextsPathExists"));
        }

        [TestMethod]
        public void TestCreateTextsPath() {
            _privateRepo.Invoke("CreateTextsPath");
            Assert.IsTrue((bool)_privateRepo.Invoke("TextsPathExists"));
        }

        [TestMethod]
        public void TestGetTextsPath() {
            Assert.AreEqual(TEXT_FOLDER_PATH, (string)_privateRepo.Invoke("GetTextsPath"));
        }
    }
}
