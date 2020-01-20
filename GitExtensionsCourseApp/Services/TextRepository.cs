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

        private bool TextsPathExists() {
            return Directory.Exists(GetTextsPath());
        }

        private void CreateTextsPath() {
            Directory.CreateDirectory(GetTextsPath());
        }

        private string GetTextsPath() {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TEXT_FOLDER);
        }
    }
}
