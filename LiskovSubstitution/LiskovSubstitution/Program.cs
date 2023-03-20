using System;
using System.Data;

public interface Ifruit
{

    public string GetColor();
}


public class Apple : Ifruit
{

    public string GetColor()
    {

        return "Red";  



    }




}

public class Orange : Ifruit
{


    public string GetColor() { 
    
        return "Orange";


    }

}


public class call {

    static void Main() {

        Ifruit fruit = new Orange();
        string temp = fruit.GetColor();
        Console.WriteLine(temp);
        fruit = new Apple();
        temp = fruit.GetColor();
        Console.WriteLine(temp);
        
    }

}

