using System;

public class account { 


        public int accID { get; set; }
        public string accHolderName { get; set; }
        public decimal accBalance { get; set; }
    
}

public class calculateInterest {

    public decimal Interest( account acc1) {
        Console.WriteLine(acc1.accBalance*8/100);



        return 50;
    }

    public static void Main()
{ 
    
        account acc= new account(); 
        acc.accID = 1;
        acc.accBalance = 50;
        acc.accHolderName = "jayesh";
        calculateInterest calc=new calculateInterest(); 
        calc.Interest(acc);

    
    }

}