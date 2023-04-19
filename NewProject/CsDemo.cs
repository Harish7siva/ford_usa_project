using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class CsDemo
    {
        
        int a = 20;
        int b = 10;
        int c;
        public void openAccount()
        {
           c = a;//20
           a = b;//10
           b = c;//20

            Console.WriteLine("a value is" + a);
            Console.WriteLine("b value in"  + b);




        }
    
        public static void Main(string[] args) { 
        
            CsDemo demo = new CsDemo();
        
            demo.openAccount();
        
        
        
        
        
        
        
        }
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
