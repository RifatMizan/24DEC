using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Startup
    {
        public static void Main()
        {

            int a = 10; 

            Person aPerson = new Person();

            Person person2 = new Person("Sultana", "Sharmin");

            Person person3 = new Person("james", "Locus", "Scott");

            string revName = aPerson.GetReverseName();
            string fullName = aPerson.GetFullName();

            Person p4;

            

            Console.WriteLine(fullName);
            Console.WriteLine(revName);

            Console.ReadKey();


        }
    }
}
