using System;
using System.Runtime.InteropServices;

public class Myclass {


    static void Main() {

        Class1 obj = new(new Logger());
        obj.call();
    }

}