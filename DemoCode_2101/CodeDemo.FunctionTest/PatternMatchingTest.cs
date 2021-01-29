using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeDemo.Library;
using CodeDemo.Library.Biz;
using System.Collections.Generic;

namespace CodeDemo.FunctionTest
{
    [TestClass]
    public class PatternMatchingTest
    {
        [TestMethod]
        public void ShouldPattern_MatchChar()
        {
            char myChar = 'A';
            var isLetter = myChar.IsLetter();
            Assert.IsTrue(isLetter);

            myChar = '.';
            isLetter = myChar.IsLetter();
            Assert.IsFalse(isLetter);

            myChar = '.';
            isLetter = myChar.IsLetterOrSeparator();
            Assert.IsTrue(isLetter);
        }

        [TestMethod]
        public void ShouldPattern_CheckingNull()
        {
            List<int> myList = null;
            var isNull = myList.IsNull();
            Assert.IsTrue(isNull);

            myList = new List<int>();
            isNull = myList.IsNotNull();
            Assert.IsTrue(isNull);
        }

        [TestMethod]
        public void ShouldPattern_CheckingType()
        {
            var number1 = 1.12M;
            var isMatchType = PatternMatchingBiz.IsDoubleOrDecimalOrFloat(number1);
            Assert.IsTrue(isMatchType);

            var number2 = 1.24F;
            isMatchType = PatternMatchingBiz.IsDoubleOrDecimalOrFloat(number2);
            Assert.IsTrue(isMatchType);

            var number3 = 1.24;
            isMatchType = PatternMatchingBiz.IsDoubleOrDecimalOrFloat(number3);
            Assert.IsTrue(isMatchType);

            var number4 = 1;
            isMatchType = PatternMatchingBiz.IsNotDoubleOrDecimalOrFloat(number4);
            Assert.IsTrue(isMatchType);
        }

        [TestMethod]
        public void ShouldPattern_CheckingNullOrEmpty()
        {
            string? str = null;
            var isNullOrEmpty = str.IsNullOrBlankOrEmpty();
            Assert.IsTrue(isNullOrEmpty);

            str = string.Empty;
            isNullOrEmpty = str.IsNullOrBlankOrEmpty();
            Assert.IsTrue(isNullOrEmpty);

            str = "   ";
            isNullOrEmpty = str.IsNullOrBlankOrEmpty();
            Assert.IsTrue(isNullOrEmpty);

            str = "abc";
            isNullOrEmpty = str.IsNotNullOrBlankOrEmpty();
            Assert.IsTrue(isNullOrEmpty);
        }      

        [TestMethod]
        public void ShouldPattern_CheckingNot()
        {
            var person = new Person("Bill", "Jobs");
            Teacher teacher = new Teacher("Bill", "Jobs", "Sub");
            Assert.IsTrue(person is Person);
            Assert.IsTrue(teacher is Person);
            Assert.IsTrue(teacher is Teacher);
            Assert.IsTrue(person is not Teacher);
        }

        [TestMethod]
        public void ShouldPattern_CheckingLogical()
        {
            SE s = new SE { Name = "", Id = 1 };
            var name = PatternMatchingBiz.GetNameById(s);
            Assert.AreEqual("Baidu", name);
        }

        [TestMethod]
        public void ShouldPattern_CheckingTypeLogical()
        {
            var person = new Person("Bill", "Jobs");
            var student = new Student("Bill", "Jobs", 11);
            var teacher = new Teacher("Bill", "Jobs", "Sub");
            var minAge = PatternMatchingBiz.GetMinAge(teacher);
            Assert.AreEqual(25, minAge);
            minAge = PatternMatchingBiz.GetMinAge(student);
            Assert.AreEqual(6, minAge);
            minAge = PatternMatchingBiz.GetMinAge(person);
            Assert.AreEqual(30, minAge);
        }

        [TestMethod]
        public void ShouldPattern_GetStudentSchoolNam()
        {
            var student = new Student("Bill", "Jobs", 30);
            var schoolName = PatternMatchingBiz.GetEducationName(student);
            Assert.AreEqual("University", schoolName);
            var student2 = new Student("Bill", "Jobs", 5);
            schoolName = PatternMatchingBiz.GetEducationName(student2);
            Assert.AreEqual("Pre-Primary", schoolName);
        }

    }
}
