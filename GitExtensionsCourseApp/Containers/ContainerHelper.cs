using GitExtensionsCourseApp.Services;
using Unity;
using Unity.Lifetime;

namespace GitExtensionsCourseApp.Containers {
    public static class ContainerHelper {
        public static IUnityContainer Container { get; private set; }
        static ContainerHelper() {
            Container = new UnityContainer();
            Container.RegisterType<ITextRepository, TextRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
