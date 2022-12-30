using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Interface_Demo
    {
        public void Add (int a, int b);


    }
    class Sum : Interface_Demo
    {
        public void Add (int a,int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
