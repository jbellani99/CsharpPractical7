using System;
using System.Security.Cryptography.X509Certificates;

public class Invoice {


    public virtual double GetInvoiceDiscount(double amt) {

        amt = amt * 10 / 100;
        return amt;

    }


}
public class FinalInvoice:Invoice {

    public override double GetInvoiceDiscount(double amt)
    {

        amt = amt * 5 / 100;
        return amt;

    }

}
public class RecurringInvoice : Invoice
{

    public override double GetInvoiceDiscount(double amt)
    {

        amt = amt * 15 / 100;
        return amt;

    }

}
public class ProposedInvoice: Invoice
{

    public override double GetInvoiceDiscount(double amt)
    {

        amt = amt * 2 / 100;
        return amt;

    }

}

public class call {

    public static void Main() { 
    
            Invoice objInv=new Invoice();
            double temp= objInv.GetInvoiceDiscount(1000);
            Console.WriteLine(temp);
            
            FinalInvoice objFInv=new FinalInvoice();
            temp= objFInv.GetInvoiceDiscount(1000); 
            Console.WriteLine(temp);
            
            ProposedInvoice ObjPInv=new ProposedInvoice();
            temp= ObjPInv.GetInvoiceDiscount(1000);
            Console.WriteLine(temp);    
                
            RecurringInvoice objRInv=new RecurringInvoice();
            temp=objRInv.GetInvoiceDiscount(1000);  
            Console.WriteLine(temp);
            
    
    }


}


