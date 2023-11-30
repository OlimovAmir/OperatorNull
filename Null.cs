using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorNull
{
     class Null
    {
        static void Main(string[] args)
        {
            //string str = "test";
            string str = null;

          Console.WriteLine(str ?? "not Data");

            
        }
    }
}
