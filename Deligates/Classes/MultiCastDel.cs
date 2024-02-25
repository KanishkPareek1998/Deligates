using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates.Classes
{
    public class MultiCastDel
    {
        public delegate void Operation(int x, int y);
        private static Operation delegate1 = Add;
        private static Operation delegate2 = Subtract;
        public Operation MultiCastDeligate = delegate1+ delegate2;
        public Operation getMultiCastDeligate()
        {
            return MultiCastDeligate;
        }
        static void Add(int x, int y)
        {
            Console.WriteLine($"Addition: {x + y}");
        }

        static void Subtract(int x, int y)
        {
            Console.WriteLine($"Subtraction: {x - y}");
        }
    }
}
