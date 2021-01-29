using System.Collections.Generic;
using Xunit;
using CodeDemo.Library.Biz;

namespace CodeDemo.Test
{
    public class PatternMatchingTest
    {
        [Fact]
        public void ShouldPattern_MatchChar()
        {
            char myChar = 'A';
            var isLetter = myChar.IsLetter();
            Assert.True(isLetter);

            myChar = '.';
            isLetter = myChar.IsLetter();
            Assert.False(isLetter);

            myChar = '.';
            isLetter = myChar.IsLetterOrSeparator();
            Assert.True(isLetter);
        }

        [Fact]
        public void ShouldPattern_CheckingNull()
        {
            List<int> myList = null;
            var isNull = myList.IsNull();
            Assert.True(isNull);

            myList = new List<int>();
            isNull = myList.IsNotNull();
            Assert.True(isNull);
        }


    }
}
