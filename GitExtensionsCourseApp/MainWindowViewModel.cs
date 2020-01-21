using GitExtensionsCourseApp.Containers;
using GitExtensionsCourseApp.ViewModels;
using Unity;

namespace GitExtensionsCourseApp {
    public class MainWindowViewModel {
        public object List { get; private set; }
        public object Actions { get; private set; }

        public MainWindowViewModel() {
            List = ContainerHelper.Container.Resolve<PersonListViewModel>();
            Actions = ContainerHelper.Container.Resolve<ActionsViewModel>();
        }
    }
}
