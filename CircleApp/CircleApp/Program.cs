using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle();
            aCircle.radius = 12;
            Console.WriteLine(aCircle.GetArea());

            Console.ReadKey();
        }
    }
}
