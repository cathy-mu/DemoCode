using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeDemo.Library;
using CodeDemo.Library.Biz;
using System; 


namespace CodeDemo.FunctionTest
{
    [TestClass]
    public class FitAndFinishTest
    {
        #region
        [TestMethod]
        public void ShouldRecord_StaticAnonymous_Works()
        {
            const string text = "{0} is a good searchengine!";
            var result = StaticAnonymousFunBiz.DoSomethingForSearchEngine(static se => String.Format(text, se));

            foreach (var s in StaticAnonymousFunBiz.seList)
            {
                Assert.IsTrue(result.Contains(s));
            }
        }
        #endregion

        #region Covariant Return Types
        [TestMethod]
        public void ShouldRecord_CovariantReturnTypes_Works1()
        {
            MyClass myClass = new MyClass();
            var result = myClass.MyMethod();
            Assert.IsTrue(result is string);
        }

        [TestMethod]
        public void ShouldRecord_CovariantReturnTypes_Works2()
        {
            var book = new Book("My book", 1, "978-3-16-148410-0");
            var music = new Music("My music", 2, Format.Disc);
            var quantity = 1;
            BookOrder orderBook = book.Order(quantity);
            MusicOrder orderMusic = music.Order(quantity);
            //Before C# 9
            //BookOrder oldBook = (BookOrder)book.Order(1);//Cast from ProductOrder  
            //MusicOrder oldMusic = (MusicOrder)music.Order(1);

            Assert.IsTrue(orderBook is BookOrder);
            Assert.IsTrue(orderBook.Quantity.Equals(quantity));
            Assert.IsTrue(orderMusic is MusicOrder);
            Assert.IsTrue(orderMusic.Quantity.Equals(quantity));

         }
        #endregion


    }

}
