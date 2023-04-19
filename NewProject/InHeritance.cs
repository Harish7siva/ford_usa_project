using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Grandfather
    {

        public void farmland()
        {
            Console.WriteLine("this is grandfather farmland");
        }

        public void tractor()
        {
            Console.WriteLine("this is grandfather tractor");
                
        }

    }

    internal class FatherHouse : Grandfather 
        {

            public void house()
            {

                Console.WriteLine("this is father house");

            }

            public void tvsbike()
            {
                Console.WriteLine("this is father bike");
            }
        }
  
    internal class DaughterHouse : FatherHouse
    {
            public void vespabike()
        {
            Console.WriteLine("this is daughter vespabike");
        }
             
            public void samsungmobile()
        {
            Console.WriteLine("this is daughter samsungmobile");
        }
            

        public static void Main(string[] args) 
        {
        
           DaughterHouse dh = new DaughterHouse();
           
            dh.farmland();
            dh.tractor();
            dh.tvsbike();
            dh.samsungmobile();
            dh.vespabike();
            dh.house();
            
        
        
        
        }






    }
    
    
    
    
    
    
    
    
    
    
    
       }







        







    
        







