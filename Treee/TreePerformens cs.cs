using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Treee
{
    internal class TreePerformens_cs<T>
    {
        public delegate T Method();
        public static void Measure(string message, Method method)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            T value = method();
            sw.Stop();
            Console.WriteLine($"{ message}:{value},вычесленно за {sw.Elapsed.TotalMilliseconds} ms");
        }


    }
}
