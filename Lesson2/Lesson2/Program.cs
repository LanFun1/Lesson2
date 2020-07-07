using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int images = 52;
            int lines = images / 3;
            int extraImages = images % 3;

            Console.WriteLine("lines  = " + lines + "\nextraImages = " + extraImages);
        }
    }
}
