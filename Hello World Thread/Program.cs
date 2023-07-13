using System;
using System.Threading;

//ref link:https://www.youtube.com/watch?v=-s8dOv5G8WA&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5
// Threading -- Basic

class MainClass
{
    static void Main()
    {
        //Console.WriteLine("My Name");
        var thread = new Thread(DifferentMethod);
        thread.Start();
    }
    static void DifferentMethod()
    {
        Console.WriteLine("My Name");
    }
}