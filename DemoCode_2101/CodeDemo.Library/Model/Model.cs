using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.Library
{
    #region Records
    public record Person
    {
        public string LastName { get; set; }
        public string FirstName { get; init; } //init-only property

        public Person(string first = "Bill", string last = "Jobs") => (FirstName, LastName) = (first, last);

        public void Deconstruct(out string first, out string last)
        {
            first = FirstName;
            last = LastName;
        }
    }

    //Records by default Public Setter, Construct, Deconstruct
    public record MyPerson(string FirstName, string LastName);

    public record MyPersonChangeName(string FirstName, string LastName)
    {
        protected string ReName { get; init; } = FirstName;
        public string ReNameL { get; init; } = LastName;
    }

    //Inheritance
    public record Teacher : Person
    {
        public string Subject { get; }//default init-only property

        public Teacher(string first, string last, string sub)
            : base(first, last) => Subject = sub;
    }

    public record Employee(string FirstName, string LastName, int id) : Person(FirstName, LastName)
    {
        public int ID { get => id; set => ID = value; }
    }

    //Sealed
    public sealed record Student : Person
    {
        public int Level { get; }

        public Student(string first, string last, int level) : base(first, last) => Level = level;
    }

    public record AnotherPerson : Person
    {
        public AnotherPerson(string first, string last) : base(first, last)
        {
        }
    }

    public class PersonClass
    {
        public string LastName { get; }
        public string FirstName { get; }

        public PersonClass(string first, string last) => (FirstName, LastName) = (first, last);
    }

    #endregion


    public record SearchEngine
    {
        //read only property
        private readonly string name = "<unknown>";
        private readonly string language = "<unknown>";

        public string Name
        {
            get => name;
            init => name = (value ?? throw new ArgumentNullException(nameof(name)));//set value even readonly
        }
        public string Language
        {
            get => language;
            init => language = value;
        }
        public SearchEngine(string name, string lan) => (Name, Language) = (name, lan);
    }

    public class SE
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }


    public record MyNumberA
    {
        public int Num { get; set; }
    }

    public record MyNumberB
    {
        public int Num { get; set; }
    }
}




