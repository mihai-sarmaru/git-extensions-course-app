using GitExtensionsCourseApp.Models;
using System.Collections.Generic;

namespace GitExtensionsCourseApp.Services {
    public interface ITextRepository {
        IEnumerable<Person> GetAllPersons();
        double CalculateAverageAge();
    }
}