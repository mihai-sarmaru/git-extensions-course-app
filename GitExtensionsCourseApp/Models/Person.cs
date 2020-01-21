using System;

namespace GitExtensionsCourseApp.Models {
    public class Person {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() {
            ID = Guid.NewGuid().ToString();
        }
    }
}
