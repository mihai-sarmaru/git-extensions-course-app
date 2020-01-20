using GitExtensionsCourseApp.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace GitExtensionsCourseApp.Services {
    public class TextRepository : ITextRepository {
        private readonly string TEXT_FOLDER = "texts";

        public IEnumerable<Person> GetAllPersons() {
            throw new NotImplementedException();
        }

        private bool GetTextsPath() {
            return Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TEXT_FOLDER));
        }

        private void CreateTextsPath() {
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TEXT_FOLDER));
        }
    }
}
