using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            [Conditional("DEBUG")]
            static void DoAction()
            {
                // Perform action

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Performing action in debug mode");
                Console.WriteLine("-------------------------------");
            }

            DoAction();

            //Before C# 9
//#if DEBUG
//            DoAction();
//#endif
        }
    }
}
