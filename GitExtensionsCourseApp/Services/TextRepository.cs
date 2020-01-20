using System;
using System.IO;

namespace GitExtensionsCourseApp.Services {
    public class TextRepository {
        private readonly string TEXT_FOLDER = "texts";

        private bool GetTextsPath() {
            return Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TEXT_FOLDER));
        }

        private void CreateTextsPath() {
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TEXT_FOLDER));
        }
    }
}
