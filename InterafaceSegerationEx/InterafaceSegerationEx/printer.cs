using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterafaceSegerationEx
{
    /* 
     * This is before when we don't Segregate 
     * public  interface printer
     {
         void Print();
         void Fax();
         void Scan();
         void PrintDuplex();




     }*/

    public interface IPrinter {


        void Print();
        void Scan();

    }
    public interface IDuplexPrint {

        void PrintDuplex();


    }
    public interface IFax
    {
        void Fax();


    }
}
