using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Incdec
    {

        int var1 = 10;


        public void ExecNumbers()
        {

            Console.WriteLine(var1);
            Console.WriteLine(var1++);
            Console.WriteLine(var1);
            Console.WriteLine(var1--);
            Console.WriteLine(var1);
            Console.WriteLine(++var1);
            Console.WriteLine(var1);
            Console.WriteLine(--var1);
            Console.WriteLine(var1);
        }

        public static void Main(string[] args)
        {
            Incdec demo = new Incdec();

            demo.ExecNumbers();



        }
    
    
    
    
    
    
    }
}
