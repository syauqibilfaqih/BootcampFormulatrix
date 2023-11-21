// Encapsulation example

class Program : Parent
{
	static void Main()
	{
		Parent p = new Parent();
		Child c = new Child();
		Program pr = new Program();
		
		c.a = 9;
		c.a.Dump();
		pr.b.Dump();
		// p.b.Dump(); //Can't be accessed since "b" is protected
		// c.c.Dump(); //Can't be accessed since "c" is protected
		// p.c.Dump(); //Can't be accessed since "c" is protected
		c.getValue("c").Dump(); //Accessing _c through function 
		c.d = 11;
		c.e = 15;
		c.d.Dump();
		c.e.Dump();		
	}
}

class Parent
{
	public int a;
	protected int b=5;
	private int _c=3;
	
	public int getValue(string value)
	{
		if(value == "a")
		{
			return a;
		}
		if(value == "b")
		{
			return b;
		}
		if(value == "c")
		{
			return _c;
		}
		else
		{
			return 0;
		}
	}
}

class Child : Parent
{
	public int d;
	public int e;

}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}