using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeDemo.Library.Biz
{
    public static class TargetTypedBiz
    {
        public static void DeclareType()
        {
            //C# 3-
            Dictionary<string, List<int>> dic1 = new Dictionary<string, List<int>>();

            //C# 3
            var dic2 = new Dictionary<string, List<int>>();

            //C# 9
            Dictionary<string, List<int>> field = new();
        }

        public static void InitOwnType()
        {
            Dictionary<string, List<int>> dic1 = new()
            {
                { "google", new() { 4, 5, 17 } },
                { "baidu", new() { 1, 392 } }
            };

            SearchEngineIds ids = new(1, 2, 3);

            //Target-typed with "with"
            Person p1 = new();
            var p2 = p1 with { FirstName = "Tom" };


            //Can't use for Value type and No type
            var x = default(int);//use default  
            int t = new();            
            //var x = new();

        }

        public static void MethodsParaTypeTarget()
        {
            MyMethod(para: new());
            MyMethod(new (), new Para());
            MyMethod(new SearchEngineIds(), new());


            //Can't use for ambiguous overload
           //MyMethodA(new(),new());
            MyMethodA(new Para(), 0);
            MyMethodA("sss", new Para());
        }

        #region Some methods 
        public static void MyMethod(Para para)
        {
            //do something ....
        }

        public static void MyMethod<T>(T t1, T t2) { }


        public static void MyMethodA(object a, Para b) => Console.Write($"{a} {b}");
        public static void MyMethodA(Para a, object b) => Console.Write($"{a} {b}");

        #endregion 
    }


    #region Models

    public class SearchEngineIds
    {
        public SearchEngineIds(params int[] p) { }
    }

    public class Para { }

    #endregion   

}
