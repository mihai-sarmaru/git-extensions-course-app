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

        private string ExtractName(string[] fileLines) {
            if (fileLines == null) return string.Empty;
            if (fileLines.Length < 1 || string.IsNullOrEmpty(fileLines[0])) return string.Empty;
            return fileLines[0];
        }

        private int ExtractAge(string[] fileLines) {
            if (fileLines == null) return 0;
            if (fileLines.Length < 2 || string.IsNullOrEmpty(fileLines[1])) return 0;
            int result = 0;
            return int.TryParse(fileLines[1], out result) ? result : 0;
        }
    }
}
