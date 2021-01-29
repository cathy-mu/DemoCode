using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeDemo.Library.Biz
{

    #region Static Anonymous Function
    //use static in lambda expression and anonymous function
    public class StaticAnonymousFun
    {
        Action<int> nc = static delegate (int x) { Console.WriteLine("Anonymous Method: {0}", x); };
        Action<int> la = static (int a) => a++;
    }
    public static class StaticAnonymousFunBiz
    {
        public static List<string> seList = new (){ "Google", "Baidu", "Bing" };

        public static String DoSomethingForSearchEngine(Func<string, string> func)
        {
            StringBuilder sb = new();
            foreach (var se in seList)
            {
                sb.Append(func(se));
            }
            return sb.ToString();
        }
    }

    #endregion

   

      
}
