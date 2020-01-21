using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GitExtensionsCourseApp.Messages;
using GitExtensionsCourseApp.Models;
using GitExtensionsCourseApp.Services;
using PropertyChanged;

namespace GitExtensionsCourseApp.ViewModels {
    [AddINotifyPropertyChangedInterface]
    public class PersonListViewModel {
        private ITextRepository _repo;
        public ObservableCollection<Person> PersonList { get; private set; }
        public ICommand RefreshCommand { get; private set; }

        public PersonListViewModel(ITextRepository repo) {
            _repo = repo;
            PersonList = new ObservableCollection<Person>(_repo.GetAllPersons());
            RefreshCommand = new RelayCommand(OnRefresh);
        }

        private void OnRefresh() {
            PersonList = new ObservableCollection<Person>(_repo.GetAllPersons());
            Messenger.Default.Send(new UpdateMergeButtonMessage());
        }
    }
}
