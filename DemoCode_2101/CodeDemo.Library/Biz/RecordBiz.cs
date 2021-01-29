using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.Library.Biz
{
    public class RecordBiz
    {
        public void InitPerson()
        {
            var person = new Person("Bill", "Green");
            var (first, last) = person;

            //C# 9 default Records
            var myPerson = new MyPerson("Bill", "Green");
            var (myfirst, mylast) = myPerson;
            var getName = myPerson.FirstName;
            var myPersonRename = new MyPersonChangeName("Bill", "Green");
            var (myFirstNew, myLastNew) = myPersonRename;


            //With-expressions
            Person brother = person with { FirstName = "Paul" };
            //brother.FirstName = "first"; //init only
            brother.LastName = "last";

            var (f, l) = brother;
            Employee employee = new Employee(f, l, 10000);


            Teacher teacher = new Teacher("teacherfirst", "teacherlast", "Math");
            //property default setter is init only
            //teacher.Subject = "English";
        }



    }
}
