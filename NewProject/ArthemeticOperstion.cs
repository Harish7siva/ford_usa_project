using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class ArthemeticOperstion
    {

        public void addNumbers()
        {
            Console.WriteLine("Addition is" + (10 + 20));
        }
    
        public void addNumbers(int a, int b)
        {
            Console.WriteLine("Addition is" + (a + b));
        }
    
        public void addNumbers( int a,  double  b)
        {
            Console.WriteLine(" Addition is" + ( a + b));
        }

        public void addnumbers(double a , int b)
        {

            Console.WriteLine(" Addition is" + ( a + b));
        }

        public void addnumbers(int a , int b , int c)
        {
            Console.WriteLine("Addition is " + (a + b));
                
                
        }





        public static void Main(string[] args)
        {
        
          ArthemeticOperstion op = new ArthemeticOperstion();
        
         op.addNumbers();
         op.addNumbers(16, 28);
         op.addNumbers(10, 30.2);
         op.addnumbers(20.0,40);
         op.addnumbers(10, 20, 30);      
                
        }

       
    }
}
