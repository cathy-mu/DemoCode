using System;
using Xunit;
using CodeDemo.Library;

namespace CodeDemo.Test
{
    public class RecordTest
    {
        [Fact]
        public void ShouldRecord_CampareSame()
        {
            var firstName = "Bill";
            var lastName = "Wagner";
            var person1 = new PersonClass(firstName, lastName);
            var samePerson1 = new PersonClass(firstName, lastName);
            Assert.NotEqual(person1, samePerson1);

            var person = new Person(firstName, lastName);
            var samePerson = new Person(firstName, lastName);
            Assert.Equal(person, samePerson);

            var student = new Student(firstName, lastName, 11);
            Assert.NotEqual(person, student);

            var google = new SearchEngine("Google", "English");
            Assert.Throws<ArgumentNullException>(() => google with { Name = null });
            var google1 = google with { Language = null };
            
        }


    }
}
