using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligates.Classes
{
    public delegate void MyDelegate(string message);
    public class SimpleDelTest
    {
        public MyDelegate SimapleDeligate = new MyDelegate(PrintMessage);

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
