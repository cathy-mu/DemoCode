if (args is { Length: > 0 })
{
    System.Console.WriteLine($"Hello World! {args[0]}");
}
System.Console.WriteLine($".Net Frame Work version {System.Environment.Version}");
await System.Threading.Tasks.Task.Delay(10000);

//Before C# 9
//using System;
//using System.Threading.Tasks;
//class Program
//{
//    static void Main(string[] args)
//    {
//        if (args!=null && args.Length>0)
//        {
//            Console.WriteLine($"Hello World! {args[0]}");
//        }
//        Console.WriteLine($".Net Frame Work version {Environment.Version}");
//        await System.Threading.Tasks.Task.Delay(10000);
//    }
//}