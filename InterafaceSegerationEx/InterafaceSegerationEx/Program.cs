using InterafaceSegerationEx;
using System;
public class HpPrinter : IPrinter {

   public void Print()
    {
        Console.WriteLine("The printer Print method.....");
    }
    public void Scan()
    {
        Console.WriteLine("The printer  Scan Method.....");
    }
    
}



public class call
{
    public static void Main(string[] args) { 
    
    
        HpPrinter objhp=new HpPrinter();    
        objhp.Print();  
        objhp.Scan();
        LiquidPrinter   objLP=new LiquidPrinter();
        objLP.Print();  
        objLP.Scan();
        objLP.Fax();
        objLP.PrintDuplex();
    }



}