using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.Models;
using GitExtensionsCourseApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
        public void TestGetAllPersons() {
            List<Person> personList = new List<Person>(_repo.GetAllPersons());

            Assert.IsNotNull(personList);
            Assert.AreEqual(0, personList.Count);
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

        [DataTestMethod]
        [DataRow("", null)]
        [DataRow("", new object[1] { new string[] { } })]
        [DataRow("", new object[1] { new string[1] { "" } })]
        [DataRow("Smith", new object[1] { new string[1] { "Smith" } })]
        public void TestExtractName(string expected, string[] input) {
            string result = (string)_privateRepo.Invoke("ExtractName", new object[1] { input });
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(0, null)]
        [DataRow(0, new object[1] { new string[] { } })]
        [DataRow(0, new object[1] { new string[1] { "" } })]
        [DataRow(0, new object[1] { new string[2] { "", "Smith" } })]
        [DataRow(7, new object[1] { new string[2] { "", "7" } })]
        [DataRow(0, new object[1] { new string[2] { "", "" } })]
        [DataRow(0, new object[1] { new string[2] { "", "Smith7" } })]
        [DataRow(7, new object[1] { new string[2] { "", "7" } })]
        [DataRow(0, new object[1] { new string[2] { "", "0.7" } })]
        public void TestExtractAge(int expected, string[] input) {
            int result = (int)_privateRepo.Invoke("ExtractAge", new object[1] { input });
            Assert.AreEqual(expected, result);
        }
    }
}
