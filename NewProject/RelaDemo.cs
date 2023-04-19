using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class RelaDemo
    {

           int a = 10;
           int b =  3;

      public void CompareNumbers()
    {
   
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);        
            Console.WriteLine(a <=b);
            Console.WriteLine(a >=b);
            Console.WriteLine(a ==b);
            Console.WriteLine(a !=b);
        
        
        
        
        }
      public static void Main(string[] args)    
    {

            RelaDemo demo = new RelaDemo();
            demo.CompareNumbers();
            
    }



    }









}
