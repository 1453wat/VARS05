using OpenTracing;
using System;
using System.Linq;

namespace VARS05
{
    class Program
    {
         
        static void Main(string[] args )
        {
            string[] meyveler = { "elma", "armut", "muz", "üzüm", "seftali" };
            var meyve = from m in meyveler
                        where m[0] == 'a'
                        select m;

            Console.WriteLine(meyve);
        }
    }
}
