using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterafaceSegerationEx
{
public  class LiquidPrinter:IPrinter,IDuplexPrint,IFax
    {
         public void Print()
        {
            Console.WriteLine("The LiquidPrinter Print method.....");
        }
        public void Scan()
        {
            Console.WriteLine("The LiquidPrinter  Scan Method.....");
        }

        public void Fax()
        {
            Console.WriteLine("The LiquidPrinter Fax Method.....");
        }
        public void PrintDuplex()
        {

            Console.WriteLine("The LiquidPrinter DuplexPrint.....");
        }

    }
}
