using DependencyInversion;
using System;

//High level Module


public class Class1
{

    private IAccess _interface;
     public  Class1(IAccess Iaccess)
    {
        _interface = Iaccess;

       
    }


    public void call() {


        var store =_interface.GetDeatils();

        Console.WriteLine($"{store.id} {store.Password}");

    }


}
