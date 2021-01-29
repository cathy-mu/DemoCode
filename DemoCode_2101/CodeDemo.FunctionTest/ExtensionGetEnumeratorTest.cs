using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CodeDemo.Library;
using CodeDemo.Library.Biz;


namespace CodeDemo.FunctionTest
{
    [TestClass]
    public class ExtensionGetEnumeratorTest
    {
        [TestMethod]
        public void Should_GetIEnumerator()
        {
            var PersonList = new Person[3]
            {
                new ("John", "Smith"),
                new ("Jim", "Johnson"),
                new ("Sue", "Rabon"),
            };

            List<string> nameList = new();

            var people = new People(PersonList);
            foreach (var person in people)
            {
                nameList.Add(person.FirstName);
            }

            Assert.IsTrue(nameList.Count.Equals(PersonList.Length));
        }



    }

}
