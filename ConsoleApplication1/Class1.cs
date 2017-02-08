using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class Class1
  {
      public delegate int Print(int value, int value2);
        public int add(int a, int b)
        {
            return a + b;
        }

 public  Print print = delegate(int val, int val2)
        {
            return val + val2;
        };

    }
}
