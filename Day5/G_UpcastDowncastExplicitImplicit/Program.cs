class Program
{
	static void Main() {
	int a  = 3;
	double b = a;
	b.Dump();
	
	double c = 3.1;
	int d = (int)c;
	d.Dump();
}

}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}