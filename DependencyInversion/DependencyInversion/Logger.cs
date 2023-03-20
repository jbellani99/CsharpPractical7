using DependencyInversion;
using System;
using System.ComponentModel;

public class Logger:acess
{

	public int id { get; set; }
	public string Password { get; set; }

    public Logger getdeatils()
    {

        Logger obj = new Logger();
        obj.id = 10001;
        obj.Password = "password";

        return obj;


    }


}
