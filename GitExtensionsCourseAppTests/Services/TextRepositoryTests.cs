using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace GitExtensionsCourseAppTests.Services {
    [TestClass]
    public class TextRepositoryTests {
        private TextRepository _repo;
        private PrivateObject _privateRepo;

        [TestInitialize]
        public void Initialize() {
            _repo = ContainerHelper.Container.Resolve<TextRepository>();
            _privateRepo = new PrivateObject(_repo);
        }
    }
}
