using System;
using CJE;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CJE.Event e = new Event();
            Console.WriteLine("Hello World!" + e);
        }
    }
}