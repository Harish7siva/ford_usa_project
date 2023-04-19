using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class LogDemo
    {

        int a = 10;
        int b = 5;

        public void comparenumbers()

        {
            Console.WriteLine((a > b) && (a == b));
            Console.WriteLine((a < b) && (a > b));
            Console.WriteLine((a > b) || (a > b));
            Console.WriteLine(!(a <b) && (a>=b)); 



        }


        public static void Main(string[] args)

        {
            LogDemo demo = new LogDemo();
            demo.comparenumbers();
        }





    }




}





    
    
    
    
    
    
    
    
    
    
    
    
    



























