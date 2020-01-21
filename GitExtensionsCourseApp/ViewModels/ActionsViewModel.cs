using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitExtensionsCourseApp.Services;

namespace GitExtensionsCourseApp.ViewModels {
    public class ActionsViewModel {
        private ITextRepository _repo;

        public ActionsViewModel(ITextRepository repo) {
            _repo = repo;
        }
    }
}
