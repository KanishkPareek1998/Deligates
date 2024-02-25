using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates.Classes
{
    public class BuiltInDel
    {
        public Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
        // First in type of parameter and second in type of return type
        public Func<string, int> stringLength = str => str.Length;
        public Predicate<int> isEven = num => num % 2 == 0;
    }
}
