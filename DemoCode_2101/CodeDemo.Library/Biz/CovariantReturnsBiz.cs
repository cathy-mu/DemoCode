using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeDemo.Library.Biz
{

    public abstract class Product
    {
        protected string Name { get; }
        protected int Id { get; }

        protected Product(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public abstract ProductOrder Order(int quantity);
    }

    public class Book : Product
    {
        public string ISBN { get; }

        public Book(string name, int categoryId, string Isbn) : base(name, categoryId)
        {
            ISBN = Isbn;
        }

        //Before C# 9
        //public override ProductOrder Order(int quantity) => new BookOrder { Quantity = quantity, Product = this };
        //C# 9
        public override BookOrder Order(int quantity) => new BookOrder { Quantity = quantity, Product = this };
    }

    public class Music : Product
    {
        protected Format Format { get; }

        public Music(string name, int categoryId, Format format) : base(name, categoryId)
        {
            Format = format;
        }

        //public override ProductOrder Order(int quantity) => new MusicOrder { Quantity = quantity, Product = this };
        public override MusicOrder Order(int quantity) => new MusicOrder { Quantity = quantity, Product = this };
    }

    public class ProductOrder
    {
        public int Quantity { get; set; }
    }

    public class BookOrder : ProductOrder
    {
        public Book Product { get; set; }
    }

    public class MusicOrder : ProductOrder
    {
        public Music Product { get; set; }
    }

    public enum Format
    {
        Mp3,
        Disc
    }




    #region Covariant Return Types
    abstract class PresonInfo
    {
        public abstract Person GetPerson();
    }

    class StudentInfo : PresonInfo
    {
        public override Student GetPerson() => new Student("Kate", "White", 12);
    }

    #region interface

    //interface not support
    //interface MyInterA
    //{
    //    object MyMethod();
    //}

    //class MyClassA : MyInterA
    //{
    //    public string MyMethod() => throw new NotImplementedException();
    //}


    interface MyInter
    {
        object MyMethod();
    }

    public class MyClass : MyInter
    {
        public string MyMethod() => "my method";
        object MyInter.MyMethod() => MyMethod();
    }

    #endregion
    #endregion

}
