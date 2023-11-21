//To try
class Program {
	static void Main() {
		Child c = new Child(1,2,3,4);
		Parent p = c;

		p.a.Dump(); 
		p.b.Dump();
		// p.c.Dump(); // Can't run this because Parent doesn't contain a definition for c
		// p.d.Dump(); // Can't run this because Parent doesn't contain a definition for d
		
		Parent p1 = new Parent(1,2);
		// Child c1 = p1; // Can't run this because Parent doesn't fulfill the Child variable requirements
	}
}

class Parent
{
	public int a;
	public int b;
	public Parent(int a, int b) {
		this.a = a;
		this.b = b;
	}
}
class Child : Parent
{
	public int c;
	public int d;
	public Child(int a, int b, int c, int d) : base(a,b) 
	{
		this.c = c;
		this.d = d;
	}
}

//This is Extension Method
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}