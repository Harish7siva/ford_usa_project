using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class ShortHand
    {
        int a = 10;
        int b = 3;



        public void CompareNumbers()

        {
            a = a + b;
            Console.WriteLine(a);





        }
    
         public static void Main(string[] args)

        {
            ShortHand hand = new ShortHand();   
            hand.CompareNumbers();

        }
    
    
    
    
    
    
    
    
    }
}
