using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class StringDemo
    {

        string str = ".Net Devolper";
        
        public void demomethods()
        {
            string str1 = str.Replace(".Net", "Java");
            Console.WriteLine(str1);
        }

        public static void Main(string[] args)
        {
           StringDemo demo = new StringDemo();  
            demo.demomethods();

        }

    
    
    
    
    
    }
}
