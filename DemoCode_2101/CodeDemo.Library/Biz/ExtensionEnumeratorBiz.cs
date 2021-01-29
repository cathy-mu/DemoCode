using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeDemo.Library.Biz
{
    public class People : IDisposable//: IEnumerator<Person>
    {
        int position = -1;
        private Person[] _people { get; init; }
        public People(Person[] people)
        {
            _people = people;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            Reset();
        }
    }

    public static class PeopleExtensions
    {
        //public static IEnumerator<T> GetEnumerator<T>(this IEnumerator<T> people) => people;
        public static People GetEnumerator(this People people) => people;
    }

}