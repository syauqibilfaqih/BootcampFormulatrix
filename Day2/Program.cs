// See https://aka.ms/new-console-template for more information
using Animal;
class Program
{
	static void Main()
	{
		Cat pokariswet = new Cat("White", 5, true, 10.7F);
		Console.WriteLine(pokariswet.colour);
		
		Cat jiji = new Cat();
		Console.WriteLine(jiji.colour);
		
		Cat blacky = new Cat(isMale : false, colour : "Black", age : 4,  weight : 8.7F);
		Console.WriteLine(jiji.isMale);
		
		Cat persi = new Cat()
		{
			colour = "Orange",
			age = 2,
			weight = 4.5f 
		};
		Console.WriteLine(persi.age);
		persi.Eat("iwak");
		
	}
}

