using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C04W02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 89;
            Console.WriteLine( x.Negate());
            Console.ReadKey();
        }
        
    }
    public static class Extend
    {
        public static int Negate(this int i)
        {
            return -i;
        }
    }
}
