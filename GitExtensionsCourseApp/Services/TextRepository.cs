using GitExtensionsCourseApp.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace GitExtensionsCourseApp.Services {
    public class TextRepository : ITextRepository {
        private readonly string TEXT_FOLDER = "texts";
        private readonly string SEARCH_PATTERN = "*.txt";

        public IEnumerable<Person> GetAllPersons() {
            if (!TextsPathExists()) CreateTextsPath();

            List<Person> personList = new List<Person>();
            foreach (string fileName in Directory.GetFiles(GetTextsPath(), SEARCH_PATTERN)) {
                string[] fileLines = File.ReadAllLines(fileName);
                personList.Add(new Person() { Name = ExtractName(fileLines), Age = ExtractAge(fileLines) });
            }
            return personList;
        }

        public double CalculateAverageAge() {
            List<Person> personList = new List<Person>(GetAllPersons());
            if (personList.Count == 0) return 0;

            double sumOfAges = 0;
            foreach (Person person in personList) sumOfAges += person.Age;
            return sumOfAges / personList.Count;
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
