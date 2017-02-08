using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
namespace ConsoleApplication1
{
    class Program
    {
       
       
    
        static void Main(string[] args)
        {
            Class1 cls = new Class1();

            Stopwatch stopWatch = new Stopwatch();
                    
           
            stopWatch.Start();
               
           cls.add(2, 34);

            //cls.print(2, 34);
            stopWatch.Stop();

            Console.Write(stopWatch.ElapsedTicks);
            Console.Read();

         
        }
        
    
    }
}
