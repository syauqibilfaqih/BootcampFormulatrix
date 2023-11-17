//Value Type
class Program {
	static void Main() {
		int a = 3;
		int b = a;
		
		b = 5;
		
		a.Dump();
		b.Dump();
	}
}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}