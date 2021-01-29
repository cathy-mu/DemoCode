using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeDemo.Library;
using System;


namespace CodeDemo.FunctionTest
{
    [TestClass]
    public class RecordTest
    {
        [TestMethod]
        public void ShouldRecord_ValueEqualityComparisonsWorks()
        {
            var firstName = "Bill";
            var lastName = "Jobs";

            //Class
            var personc = new PersonClass(firstName, lastName);
            var samePersonc = new PersonClass(firstName, lastName);
            Assert.AreNotEqual(personc, samePersonc);      

            //Records, Value-based equality
            var person = new Person(firstName, lastName);
            var samePerson = new Person(firstName, lastName);
            Assert.AreEqual(person, samePerson);
            Assert.IsTrue(person==samePerson);
            Assert.IsTrue(person.Equals(samePerson));

            //different Records type with same value
            var anotherPerson = new AnotherPerson(firstName, lastName);
            var anotherPerson2 = anotherPerson with { FirstName = "Bill" };
            Assert.AreNotEqual(person, anotherPerson);
            Assert.AreEqual(anotherPerson2, anotherPerson);

            //With-expressions and inheritance
            var student = new Student(firstName, lastName, 11);
            Person personSS = student;
            var personSS2 = student;
            Assert.AreNotEqual(person, student);
            Assert.AreEqual(personSS, personSS2);
            Assert.AreNotEqual(personSS, person);
        }        

        [TestMethod]
        public void ShouldRecord_AllowSetReadOnlyVariable_NotAllowNull()
        {
            var google = new SearchEngine("Google", "English");
            Assert.ThrowsException<ArgumentNullException>(() => google with { Name = null });
            TestHelper.DoesNotThrows<ArgumentNullException>(() => { var google1 = google with { Language = null }; });
        }

        [TestMethod]
        public void ShouldRecord_NotEqual_IfDifferentType()
        {
            var num1 = new MyNumberA() { Num = 100 };
            var num2 = new MyNumberB() { Num = 100 };
            Assert.AreEqual(num1.Num, num2.Num);
            Assert.AreNotEqual(num1, num2);
        }

        [TestMethod]
        public void ShouldRecords_TargetTypeWorkWithDefaultConstructor()
        {
            Person p1 = new();
            var p2 = p1 with { FirstName = "Tom" };
            Assert.IsTrue(p2 is Person);
            Assert.AreEqual("Jobs", p2.LastName);
        }


        [TestMethod]
        public void ShouldNotClass_ValueEqualityComparisonsWorks()
        {
            var firstName = "Bill";
            var lastName = "Jobs";

            //Class
            var personc = new PersonClass(firstName, lastName);
            var samePersonc = new PersonClass(firstName, lastName);
            Assert.AreNotEqual(personc, samePersonc);
            //Assert.IsTrue(personc.Equals(samePersonc));
            //Assert.IsTrue(personc == samePersonc);
        }

    }

}
