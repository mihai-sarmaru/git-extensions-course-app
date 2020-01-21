using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GitExtensionsCourseApp.Services;
using PropertyChanged;

namespace GitExtensionsCourseApp.ViewModels {
    [AddINotifyPropertyChangedInterface]
    public class ActionsViewModel {
        private ITextRepository _repo;

        public double Average { get; set; }
        public bool IsCalculated { get; set; }
        public ICommand CalculateCommand { get; private set; }

        public ActionsViewModel(ITextRepository repo) {
            _repo = repo;
            IsCalculated = false;
            CalculateCommand = new RelayCommand(OnCalculate);
        }

        private void OnCalculate() {
            Average = _repo.CalculateAverageAge();
            IsCalculated = true;
        }
    }
}
