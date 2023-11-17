class Program{
	static void Main()
	{
		Run();
	}
}

static void Run() {
	Run();
}
//StackOverFlowException
public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}