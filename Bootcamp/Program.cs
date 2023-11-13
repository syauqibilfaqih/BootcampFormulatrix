// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
	static void Main()
	{
		Cat pokariswet = new Cat("White", 5, true, 10.7F);
		Console.WriteLine(pokariswet.colour);
		
		Cat jiji = new Cat();
		Console.WriteLine(jiji.colour);
	}
}

