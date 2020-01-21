using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GitExtensionsCourseApp.Messages;
using GitExtensionsCourseApp.Services;
using PropertyChanged;

namespace GitExtensionsCourseApp.ViewModels {
    [AddINotifyPropertyChangedInterface]
    public class ActionsViewModel {
        private ITextRepository _repo;

        public double Average { get; set; }
        public bool IsCalculated { get; set; }
        public bool HasEmployees { get; set; }
        public ICommand CalculateCommand { get; private set; }

        public ActionsViewModel(ITextRepository repo) {
            _repo = repo;
            IsCalculated = false;
            HasEmployees = _repo.Count() != 0;
            CalculateCommand = new RelayCommand(OnCalculate);
            Messenger.Default.Register<UpdateMergeButtonMessage>(this, OnUpdateMergeButtonMessageReceived);
        }

        private void OnCalculate() {
            Average = _repo.CalculateAverageAge();
            IsCalculated = true;
        }

        private void OnUpdateMergeButtonMessageReceived(UpdateMergeButtonMessage message) {
            HasEmployees = _repo.Count() != 0;
        }
    }
}
