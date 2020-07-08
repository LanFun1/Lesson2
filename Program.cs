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
            int imagesRow = 3;// по условию
            int images = 52;
            int lines = images / imagesRow;
            int extraImages = images % imagesRow;

            Console.WriteLine("lines  = " + lines + "\nextraImages = " + extraImages);
        }
    }
}
