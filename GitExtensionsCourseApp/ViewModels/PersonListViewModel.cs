using System.Collections.ObjectModel;
using GitExtensionsCourseApp.Models;
using GitExtensionsCourseApp.Services;
using PropertyChanged;

namespace GitExtensionsCourseApp.ViewModels {
    [AddINotifyPropertyChangedInterface]
    public class PersonListViewModel {
        private ITextRepository _repo;
        public ObservableCollection<Person> PersonList { get; private set; }

        public PersonListViewModel(ITextRepository repo) {
            _repo = repo;
            PersonList = new ObservableCollection<Person>(_repo.GetAllPersons());
        }
    }
}
